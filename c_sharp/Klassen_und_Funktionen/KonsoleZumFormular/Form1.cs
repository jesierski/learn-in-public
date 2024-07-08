using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KonsoleZumFormular
{   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Basisklasse basisklasse = new Basisklasse();
            basisklasse.Begruessen();
            AbgeleiteteKlasse abgKlasse = new AbgeleiteteKlasse();
            abgKlasse.Begruessen();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private int zaehler = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hallo, Welt!", "Grüße mich");
            zaehler++;
            Console.WriteLine($"Die Schaltfläche wurde {zaehler} Mal gedrückt.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int max = 256;
            int r = random.Next(0, max);
            int g = random.Next(0, max);
            int b = random.Next(0, max);
            Color color = Color.FromArgb(r, g, b);
            BackColor = color;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Text = textBox1.Text;
            MessageBox.Show("Hallo, " + Text + "!", "Personalisierte Begrüßung");
        }

        public class Basisklasse
        {
            public virtual void Begruessen()
            {
                MessageBox.Show("Willkommen im interaktiven Fenster!");
            }
        }

        public class AbgeleiteteKlasse : Basisklasse
        {
            public override void Begruessen()
            {
                MessageBox.Show("Spezielle Begrüßung!");
            }
        }
    }

}
