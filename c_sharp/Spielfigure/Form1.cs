using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Spielfigure
{
    public partial class Form1 : Form
    {
        private string Datei = @"D:\git\learn-in-public\c_sharp\Spielfigure\Images\Spinne.png";
        private Bitmap Bild_statisch;
        private int x, y, xPos, yPos, Breite, Hoehe;
        private Bitmap[] Bild = new Bitmap[4];
        private int Nr = 0;
        private int xLinks, xRechts, yOben, yUnten;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bild_statisch = (Bitmap)Image.FromFile(Datei);
            Bild[0] = new Bitmap(Bild_statisch, new Size(Bild_statisch.Width / 4, Bild_statisch.Height / 4));
            RotateImages();
            SetLimits();
            x = Breite/2;
            y = Hoehe/2;
            this.DoubleBuffered = true;
            this.BackColor = Color.DarkRed;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics Grafik = e.Graphics;
            Grafik.DrawImage(Bild[Nr], x, y);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                Nr = 3;
                if (x > xLinks) x -= 5;
                else x = xRechts;
            }
            if (e.KeyCode == Keys.Right)
            {
                Nr = 1;
                if (x < xRechts) x += 5;
                else x = xLinks;
            }
            if (e.KeyCode == Keys.Up)
            {
                Nr = 0;
                if (y > yOben) y -= 5;
                else y = yUnten;
            }
            if (e.KeyCode == Keys.Down)
            {
                Nr = 2;
                if (y < yUnten) y += 5;
                else y = yOben;
            }
            this.Refresh();
        }

        private void RotateImages() 
        {
            for (int i = 1; i < 4; i++ )
            {
                Bild[i] = (Bitmap)Bild[0].Clone();
            }
                
            Bild[1].RotateFlip(RotateFlipType.Rotate90FlipNone);
            Bild[2].RotateFlip(RotateFlipType.Rotate180FlipNone);
            Bild[3].RotateFlip(RotateFlipType.Rotate270FlipNone);
        }

        private void SetLimits() 
        {
            Breite = this.ClientSize.Width - 50;
            Hoehe = this.ClientSize.Height - 50;
            xLinks = -60; xRechts = Breite +50;
            yOben = -60; yUnten = Hoehe +50;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            xPos = e.X - 25;
            yPos = e.Y - 25;
            if (xPos < 10) xPos = 10;
            if (xPos > xRechts) xPos = xRechts;
            if (yPos < 20) yPos = 20;
            if(yPos> yUnten) yPos = yUnten;
            MoveImage();
        }

        private void MoveImage() 
        {
            if (x < xPos)
                while (x < xPos) 
                {
                    Nr = 1; x += 5;
                    Thread.Sleep(5);
                    this.Refresh();
                }
            if (y < yPos)
                while (y < yPos) 
                {
                    Nr = 2; y += 5;
                    Thread.Sleep(5);
                    this.Refresh();
                }
            if (x > xPos)
                while (x > xPos) 
                {
                    Nr = 3; x -= 5;
                    Thread.Sleep(5);
                    this.Refresh();
                }
            if (y > yPos)
                while (y > yPos) 
                {
                    Nr = 0; y -= 5;
                    Thread.Sleep(5);
                    this.Refresh();
                }
        }

    }
}
