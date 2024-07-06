using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kundenverwaltung
{
    public partial class Dialog : Form
    {
        public Kunde ReturnKunde { get; set; }

        public Dialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Kunde kunde = new Kunde(
                textBox1.Text,
                textBox2.Text,
                textBox3.Text,
                textBox4.Text,
                Int32.Parse(textBox5.Text));
                this.ReturnKunde = kunde;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Die Telefonnummer war vermutlich falsch.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
