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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.DataVisualization.Charting;

namespace PIRMS
{

    public partial class Form1 : Form
    {
        List<SerialCommunication> openComms = new List<SerialCommunication>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e) //pridat port do listu
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
                openComms.Add(new SerialCommunication(selectedPort));
                DataChart.Series.Add(selectedPort);

                // Nastavit formát grafu (osa x je datetime, typ grafu je čára)
                DataChart.Series[seriesCount].XValueType = ChartValueType.Time;
                DataChart.Series[seriesCount].ChartType = SeriesChartType.Line;
                DataChart.Series[seriesCount].Enabled = true;
                DataChart.Series[seriesCount].BorderWidth = 3;
            }
            else
            {
                MessageBox.Show("Vyberte port a zadejte boundrate");
            }

        }

        private void button5_Click(object sender, EventArgs e) //smazat port z listu
        {
            if (AddedPortsLB.SelectedItem != null)
            {
                int index = AddedPortsLB.SelectedIndex;
                AddedPortsLB.Items.Remove(AddedPortsLB.SelectedItem);
                openComms.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("Vyber položku, kterou chceš smazat.");
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            DataRefreshTimer.Enabled = true;
            foreach (SerialCommunication com in openComms)
            {
                com.Open();
            }
        }
        private void StopButton_Click(object sender, EventArgs e)
        {
            DataRefreshTimer.Enabled = false;
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

        private void DataRefreshTimer_Tick(object sender, EventArgs e)
        {
            // Zkontrolujeme, zda přišly nové data
            // Pokud ne, nic neděláme
            if (!openComms.Where(x => x.NewDataReceived).Any())
                return;

            for (int i = 0; i < openComms.Count; i++)
            {
                DataChart.Series[i].Points.AddXY(DateTime.Now, openComms[i].LastRecordedValue);
                openComms[i].NewDataReceived = false;
            }
        }
    }
}
