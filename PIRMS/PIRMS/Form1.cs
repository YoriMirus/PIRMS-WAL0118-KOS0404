using PIRMS.Communication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;

namespace PIRMS
{

    public partial class Form1 : Form
    {
        List<SerialCommunication> openComms = new List<SerialCommunication>();
        List<Tuple<DateTime, short[]>> dataSnapshots = new List<Tuple<DateTime, short[]>>();

        public Form1()
        {
            this.FormClosing += Form1_FormClosing1;
            InitializeComponent();
        }

        private void Form1_FormClosing1(object sender, FormClosingEventArgs e)
        {
            foreach (var com in openComms)
            {
                com.Close();
            }
        }

        private void AddPortButton_Click(object sender, EventArgs e) //pridat port do listu
        {
            string selectedPort = ComPortSelectCB.Text;
            string baudRate = BaudRateTB.Text;

            if (!string.IsNullOrWhiteSpace(selectedPort) && !string.IsNullOrWhiteSpace(baudRate))
            {
                // Zkontroluj, zda už tento port není vybrán
                foreach (var com in openComms)
                {
                    if (com.PortName == selectedPort)
                        return;
                }

                string combined = $"{selectedPort} - {baudRate}";
                AddedPortsLB.Items.Add(combined);

                // Přidat novou čáru do grafu
                int seriesCount = DataChart.Series.Count;
                openComms.Add(new SerialCommunication(selectedPort, SerialDataReceived));
                DataChart.Series.Add(selectedPort);

                // Nastavit formát grafu (osa x je datetime, typ grafu je čára)
                DataChart.Series[seriesCount].XValueType = ChartValueType.Double;
                DataChart.Series[seriesCount].ChartType = SeriesChartType.Line;
                DataChart.Series[seriesCount].Enabled = true;
                DataChart.Series[seriesCount].BorderWidth = 3;
            }
            else
            {
                MessageBox.Show("Vyberte port a zadejte boundrate");
            }

        }

        private void RemovePortButton_Click(object sender, EventArgs e) //smazat port z listu
        {
            if (AddedPortsLB.SelectedItem != null)
            {
                int index = AddedPortsLB.SelectedIndex;
                AddedPortsLB.Items.Remove(AddedPortsLB.SelectedItem);
                openComms.RemoveAt(index);
                DataChart.Series.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("Vyberte položku, kterou chcete smazat.");
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (openComms.Count == 0)
            {
                MessageBox.Show("Před zahájením zadejte sledované porty.");
                return;
            }

            foreach (SerialCommunication com in openComms)
            {
                try
                {
                    com.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Chyba při otevírání portu {com.PortName}:\n{ex.Message}", "Výjimka", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
        
        private void StopButton_Click(object sender, EventArgs e)
        {
            foreach (SerialCommunication com in openComms)
            {
                com.Close();
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            foreach (var serie in DataChart.Series)
            {
                serie.Points.Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadListBoxItems();
            LoadSelectedPorts();

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e) //ulozi nastaveni pri zavreni
        {
            SaveListBoxItems();
        }
        private void SaveListBoxItems() //ulozi veci z listboxu
        {
            File.WriteAllLines("settings.txt", AddedPortsLB.Items.Cast<string>());
        }
        private void LoadListBoxItems()
        {
            if (File.Exists("settings.txt"))
            {
                AddedPortsLB.Items.Clear();
                var lines = File.ReadAllLines("settings.txt");
                AddedPortsLB.Items.AddRange(lines);
            }

        }

        private void LoadSelectedPorts()
        {
            if (File.Exists("settings.txt"))
            {
                var lines = File.ReadAllLines("settings.txt");

                foreach (var line in lines)
                {
                    var parts = line.Split(new[] { " - " }, StringSplitOptions.None);
                    if (parts.Length > 0)
                    {
                        string comPort = parts[0].Trim(); // Např. "COM1"
                                                          // Přidat novou čáru do grafu
                        int seriesCount = DataChart.Series.Count;
                        openComms.Add(new SerialCommunication(comPort, SerialDataReceived));
                        DataChart.Series.Add(comPort);

                        // Nastavit formát grafu (osa x je datetime, typ grafu je čára)
                        DataChart.Series[seriesCount].XValueType = ChartValueType.Double;
                        DataChart.Series[seriesCount].ChartType = SeriesChartType.Line;
                        DataChart.Series[seriesCount].Enabled = true;
                        DataChart.Series[seriesCount].BorderWidth = 3;
                    }


                }
            }
        }

        private void SerialDataReceived(SerialCommunication com, short[] data)
        {
            // Vykreslení se musí provádět na vykreslovacím vlákně. V něm ale aktuálně nejsme, protože zpracovávání dat sériové linky se provádí ve svém vlastním vlákně
            this.Invoke(new Action( () => { DisplayFFTData(data, com.PortName); }));
        }

        private void DisplayFFTData(short[] data, string port)
        {
            dataSnapshots.Add(new Tuple<DateTime, short[]>(DateTime.Now, data));
            if (dataSnapshots.Count > 100000)
            {
                dataSnapshots.RemoveRange(0, 1000);
            }

            // Proveď FFT, tato funkce vrací seznam tuplů, každý tuple má v sobě frekvenci (Hz) a její amplitudu
            List<(double, double)> fft = SignalParsing.CalculateFft(data);

            var serie = DataChart.Series.Where(x => x.Name == port).First();
            serie.Points.Clear();

            foreach ((double,double) member in fft)
            {
                serie.Points.AddXY(member.Item1, member.Item2);
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            List<Tuple<DateTime, double>> rows = new List<Tuple<DateTime, double>>();

            for (int i = 0; i < dataSnapshots.Count; i++)
            {
                // Vzorkovací perioda je nastavena na 100 ms, takže první vzorek byl před 100 milisekundy přebrání zvuku.
                // Bude tam nějaká nepřesnost způsobená tím, že se data teprve musí poslat
                DateTime firstSampleTime = dataSnapshots[i].Item1 - TimeSpan.FromMilliseconds(100);

                // Pokud celkové vzorkování trvalo 100 ms, tak jeden vzorek trval 100ms/počet vzorků (např 100ms/50 vzorků = 2ms na vzorek
                TimeSpan sampleDuration = TimeSpan.FromMilliseconds(100.0 / dataSnapshots[i].Item2.Length);

                for (int j = 0; j < dataSnapshots[i].Item2.Length; j++)
                {
                    DateTime sampleTime = firstSampleTime + (TimeSpan.FromMilliseconds(100 + (sampleDuration.Milliseconds*j)));
                    rows.Add(new Tuple<DateTime, double>(sampleTime, dataSnapshots[i].Item2[j]));
                }
            }

            string output = "";
            while (rows.Count > 0)
            {
                output += $"{rows[0].Item1.ToShortTimeString()},{rows[0].Item2}\r\n";
                rows.RemoveAt(0);
            }

            var diag = new SaveFileDialog();
            diag.DefaultExt = "csv";
            diag.AddExtension = true;
            diag.ShowDialog();

            dataSnapshots.Clear();
        }
    }
}
