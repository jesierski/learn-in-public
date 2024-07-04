using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafikprogramm
{
    public partial class Form1 : Form
    {
        public Canvas canvas;
        public Form1()
        {
            Random random = new Random();
            this.canvas = new Canvas { Width = 800, Height = 600 };

            Button rectButton = new Button()
            {
                Text = "Rechteck zeichnen",
                Location = new Point(10, 10),
                Size = new Size(150, 30)
            };
            rectButton.Click += (sender, e) => 
            {
                int rectX = random.Next(0, canvas.Width);
                int rectY = random.Next(0, canvas.Height);
                int rectWidth = random.Next(50, 200);
                int rectHeight = random.Next(50, 200);
                Color rectColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));

                canvas.DrawRectangle(this.CreateGraphics(), rectX, rectY, rectWidth, rectHeight, rectColor);
            };

            Button circleButton = new Button()
            {
                Text = "Kreis zeichnen",
                Location = new Point(10, 50),
                Size = new Size(150, 30)
            };
            circleButton.Click += (sender, e) => 
            {
                int circleX = random.Next(0, canvas.Width);
                int circleY = random.Next(0, canvas.Height);
                int circleRadius = random.Next(20, 100);
                Color circleColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));

                canvas.DrawCircle(this.CreateGraphics(), circleX, circleY, circleRadius, circleColor);
            };

            Button clearButton = new Button()
            {
                Text = "Canvas löschen",
                Location = new Point(10, 90),
                Size = new Size(150, 30)
            };
            clearButton.Click += (sender, e) => 
            {
                Invalidate();
            };

            Controls.Add(rectButton);
            Controls.Add(circleButton);
            Controls.Add(clearButton);

            this.ClientSize = new Size(800, 600);
            this.Text = "Zeichenprogramm";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
