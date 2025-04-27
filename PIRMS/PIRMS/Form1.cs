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

namespace PIRMS
{

    public partial class Form1 : Form
    {
        List<SerialCommunication> openComms = new List<SerialCommunication>();

        public Form1()
        {
            InitializeComponent();
            // Vyvolej timer tick, aby se načetly existující porty
            this.ComPortRefreshTimer_Tick(this, new EventArgs());
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
                listBox1.Items.Add(combined);

                openComms.Add(new SerialCommunication(selectedPort));
            }
            else
            {
                MessageBox.Show("Vyberte port a zadejte boundrate");
            }
        }

        private void button5_Click(object sender, EventArgs e) //smazat port z listu
        {
            if (listBox1.SelectedItem != null)
            {
                int index = listBox1.SelectedIndex;
                listBox1.Items.Remove(listBox1.SelectedItem);
                openComms.RemoveAt(index);
            }
            else
            {
                MessageBox.Show("Vyber položku, kterou chceš smazat.");
            }
        }

        private void ComPortRefreshTimer_Tick(object sender, EventArgs e)
        {
            ComPortSelectCB.Items.Clear();
            ComPortSelectCB.Items.AddRange(SerialCommunication.GetAllAvailablePorts());
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            foreach (SerialCommunication com in openComms)
            {
                com.Open();
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            foreach (SerialCommunication com in openComms)
            {
                com.Close();
            }
        }
    }
}
