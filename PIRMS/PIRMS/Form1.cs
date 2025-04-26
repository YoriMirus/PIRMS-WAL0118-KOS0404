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
            this.Load += new EventHandler(Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "9600"; //nastavi textbox boundate na 9600 jako default
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e) //pridat port do listu
        {
            string selectedCombo = ComPortSelectCB.SelectedItem?.ToString();
            string textInput = textBox1.Text;

            if (!string.IsNullOrWhiteSpace(selectedCombo) && !string.IsNullOrWhiteSpace(textInput))
            {
                string combined = $"{selectedCombo} - {textInput}";
                listBox1.Items.Add(combined);

                // Vrátíme zpět defaultní hodnotu po přidání
                textBox1.Text = "9600";
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
