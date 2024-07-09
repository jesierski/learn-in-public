using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animation_Kreis
{
    public partial class Form1 : Form
    {
        private Graphics Grafik;
        int x = 20, y = 20, r = 200;
        // Dieses Codebeispiel zeigt, wie eine neue Bitmap programmgesteuert in C# erstellt wird.
        // Bitmap Objekt initialisieren
        private Bitmap bitmap = new Bitmap(1000, 800, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
        private string Datei = @"d:\git\learn-in-public\c_sharp\animation_kreis\images\circle1.png";


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //// erstelle die grafik auf dem screen
            //grafik = this.creategraphics();

            //// erstellen sie eine neue grafik
            //graphics graphics = graphics.fromimage(bitmap);

            //// zeichne einen kreis
            //showimage(graphics);

            //// speicher die datei
            //bitmap.save(@"d:\git\learn-in-public\c_sharp\animation_kreis\images\circle1.png");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowImage(Datei);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void ShowImage(string Datei) 
        {
            try 
            {
                pictureBox1.Load(Datei);
                //pictureBox1.Location = new Point(x,y);
            } catch (Exception) 
            {
                MessageBox.Show("Kein Bild!");
            }
        }

        public void CreateImage(Graphics graphics)
        {
            SolidBrush Pinsel = new SolidBrush(Color.Red);
            Pen Stift = new Pen(Color.Black);
            graphics.FillEllipse(Pinsel, x, y, r, r);
            graphics.DrawEllipse(Stift, x, y, r, r);

        }
    }
}
