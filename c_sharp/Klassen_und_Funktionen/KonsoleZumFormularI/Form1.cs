using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KonsoleZumFormularI
{
    public partial class Form1 : Form
    {
        Zufallsfarbe zufallsfarbe = new Zufallsfarbe();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hallo, Welt!", "Begrüßung");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Color color = zufallsfarbe.zufallsfarbeGenerieren();
            BackColor = color;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        public class Zufallsfarbe
        {
            Random random = new Random(); 
            
            public Color zufallsfarbeGenerieren()
            {    
                int max = 256;
                int r = random.Next(0, max);
                int g = random.Next(0, max);
                int b = random.Next(0, max);
                Color color = Color.FromArgb(r, g, b);
                return color;
            }
        }
    }
}
