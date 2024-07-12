using System;
using System.Windows.Forms;

namespace Pizzeria
{
    public partial class Form1 : Form
    {
        private string[] Bestellung = new string[15];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bestellung[0] = "Es wurde keine Pizzavariante gewählt.";
            Bestellung[1] = "Es wurde keine Größe gewählt.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Zusammenfassung der Bestellung";
            label1.Text += "\r\n**************************************** ";
            label1.Text += "\r\nPizzavariante: " + Bestellung[0];
            label1.Text += "\r\nPizzagröße: " + Bestellung[1];
            label1.Text += "\r\nOptionen: \r\n";
            for (int i = 2; i < 15; i++) 
            {
                if (string.IsNullOrEmpty(Bestellung[i])) { }
                else
                    label1.Text += "\t- " + Bestellung[i] + "\r\n";
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    Bestellung[0] = "Margherita"; break;
                case 1:
                    Bestellung[0] = "Salami"; break;
                case 2:
                    Bestellung[0] = "Mista"; break;
                case 3:
                    Bestellung[0] = "Funghi"; break;
                case 4:
                    Bestellung[0] = "Prosciutto"; break;
                case 5: 
                    Bestellung[0] = "Tonno"; break;
                case 6: 
                    Bestellung[0] = "Caprese"; break;
                case 7:
                    Bestellung[0] = "Vegetaria";break;
                case 8:
                    Bestellung[0] = "Diavolo"; break;
                case 9:
                    Bestellung[0] = "Quattro Formaggi"; break;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex) 
            {
                case 0:
                    Bestellung[1] = "Small"; break;
                case 1:
                    Bestellung[1] = "Medium"; break;
                case 2:
                    Bestellung[1] = "Large"; break;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                Bestellung[2] = checkBox1.Text;
            else
                Bestellung[2] = string.Empty;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
                Bestellung[3] = checkBox2.Text;
            else
                Bestellung[3] = string.Empty;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox3.Checked==true) 
                Bestellung[4] = checkBox3.Text;
            else
                Bestellung[4] = string.Empty;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked==true)
                Bestellung[5] = checkBox4.Text;
            else
                Bestellung[5] = string.Empty;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked==true)
                Bestellung[6] = checkBox5.Text;
            else
                Bestellung[6] = string.Empty;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
                Bestellung[7] = checkBox6.Text;
            else
                Bestellung[7] = string.Empty;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
                Bestellung[8] = checkBox7.Text;
            else
                Bestellung[8] = string.Empty;
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
                Bestellung[9] = checkBox8.Text;
            else
                Bestellung[9] = string.Empty;
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
                Bestellung[10] = checkBox9.Text;
            else
                Bestellung[10] = string.Empty;

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true)
                Bestellung[11] = checkBox10.Text;
            else
                Bestellung[11] = string.Empty;
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked == true)
                Bestellung[12] = checkBox11.Text;
            else
                Bestellung[12] = string.Empty;
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked == true)
                Bestellung[13] = checkBox12.Text;
            else
                Bestellung[13] = string.Empty;
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked == true)
                Bestellung[14] = checkBox13.Text;
            else
                Bestellung[14] = string.Empty;
        }
    }
}
