using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrafikHaus
{
    public partial class Form1 : Form
    {
        public Color hausFarbe = Color.Beige; 

        public Form1()
        {
            InitializeComponent();

            this.Text = "Hausfarbe ändern";
            this.Paint += new PaintEventHandler(Form1_Paint);
            this.Click += new EventHandler(colorButton_Click);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Grafik-Objekt und Zeichenstifte
            Graphics graphics = e.Graphics;
            Pen pen = new Pen(Color.Black, 2);
            Brush brushHaus = new SolidBrush(hausFarbe);
            Brush brushWiese = new SolidBrush(Color.Green);
            Brush brushHimmel = new SolidBrush(Color.LightBlue);
            Brush brushBaumstamm = new SolidBrush(Color.Brown);
            Brush brushBaumkrone = new SolidBrush(Color.DarkOliveGreen);;

            // Abmessungen des Grafik-Objekts an Formular anpassen
            int width = this.ClientSize.Width - 40;
            int height = this.ClientSize.Height - 40;

            // Haus und Landschaft zeichnen
            graphics.DrawRectangle(pen, 20, height / 2, width, height / 2 + 20);
            graphics.FillRectangle(brushWiese, 21, height / 2 + 1, width - 2, height / 2 + 18);
            graphics.DrawRectangle(pen, 20, 20, width, 80);
            graphics.FillRectangle(brushHimmel, 21, 21, width - 2, 78);
            graphics.DrawRectangle(pen, 20, 20, width, height);
            graphics.DrawRectangle(pen, width / 2 - 40, height / 2 - 40, 80, 80);
            graphics.FillRectangle(brushHaus, width / 2 - 39, height / 2 - 39, 78, 78);

            // Dach des Hauses
            Point coordDach1 = new Point();
            coordDach1.X = width / 2 - 40;
            coordDach1.Y = height / 2 - 41;
            Point coordDach2 = new Point();
            coordDach2.X = width / 2;
            coordDach2.Y = height / 2 - 70;
            Point coordDach3 = new Point();
            coordDach3.X = width / 2 + 40;
            coordDach3.Y = height / 2 - 41;
            Point[] dach = { coordDach1, coordDach2, coordDach3 };
            // Meine Sprachversion unterstützt nicht
            // PointF[] pointFs = new PointF[3];
            // Daher kein DrawPolygon()
            graphics.DrawLine(pen, coordDach1.X, coordDach1.Y, coordDach2.X, coordDach2.Y);
            graphics.DrawLine(pen, coordDach2.X, coordDach2.Y, coordDach3.X, coordDach3.Y);
            graphics.FillPolygon(Brushes.Red, dach);

            // Baum, erst Stamm, dann Krone als Kreis
            graphics.DrawRectangle(pen, width / 2 + 80, 150, 20, 120);
            graphics.FillRectangle(brushBaumstamm, width / 2 + 81, 150 + 1, 20 - 2, 120 - 2);
            graphics.DrawEllipse(pen, width / 2 + 60, 120, 60, 60);
            graphics.FillEllipse(brushBaumkrone, width / 2 + 61, 120 + 1, 60 - 2, 60 - 2);

            // Button zum Ändern der Farbe
            Button colorButton = new Button();
            colorButton.Text = "Neue Farbe";
            colorButton.SetBounds(40, 140, 80, 20);
            Controls.Add(colorButton);
            colorButton.Click += colorButton_Click;
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            hausFarbe = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
            this.Invalidate(); // Fenster neu zeichnen
        }

    }
}
