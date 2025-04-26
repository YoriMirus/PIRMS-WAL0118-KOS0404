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

        public Form1()
        {
            InitializeComponent();
            // Vyvolej timer tick, aby se načetly existující porty
            this.ComPortRefreshTimer_Tick(this, new EventArgs());
        }

        private void button4_Click(object sender, EventArgs e) //pridat port do listu
        {
            string selectedCombo = ComPortSelectCB.Text;
            string textInput = BaudRateTB.Text;

            if (!string.IsNullOrWhiteSpace(selectedCombo) && !string.IsNullOrWhiteSpace(textInput))
            {
                string combined = $"{selectedCombo} - {textInput}";
                listBox1.Items.Add(combined);

                // Vrátíme zpět defaultní hodnotu po přidání
                BaudRateTB.Text = "9600";
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
                listBox1.Items.Remove(listBox1.SelectedItem);
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
    }
}
