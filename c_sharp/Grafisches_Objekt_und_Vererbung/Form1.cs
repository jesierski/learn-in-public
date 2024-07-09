using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafisches_Objekt_und_Vererbung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Variablen Zeichenebene g, zufällige Zahl random, Farbe color 
            Graphics g = e.Graphics;
            Random random = new Random();
            Color color = new Color();
            // Wähle für color zufällige Farbe
            color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
            // Zeichne mit Stift und fülle aus mit Pinsel
            Pen Stift = new Pen(Color.Black, 2);
            Brush Pinsel = new SolidBrush(color);

            // Zeichne grafisches Objekt
            int h = this.ClientSize.Height;
            int w = this.ClientSize.Width;
            g.DrawRectangle(Stift, w / 4, h / 4, w / 4, h / 4);
            g.FillRectangle(Pinsel, w / 4 + 1, h / 4 + 1, w / 4 - 2, h / 4 - 2);

            //int w2 = Size.Width;
            //int h2 = Size.Height;
            //g.DrawRectangle(Stift, w2 / 4, h2 / 4, w2 / 4, h2 / 4);
            //g.FillRectangle(Pinsel, w2 / 4 + 1, h2 / 4 + 1, w2 / 4 - 2, h2 / 4 - 2);

        }
    }
}
