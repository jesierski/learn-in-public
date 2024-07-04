using System;
using System.Drawing;

namespace Grafikprogramm
{
	public class Canvas 
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public void DrawRectangle(Graphics grafik, int x, int y, int rectWidth, int rectHeight, Color color) 
        {
            using (SolidBrush brush = new SolidBrush(color)) 
            {
                grafik.FillRectangle(brush, x, y, rectWidth, rectHeight);
            }
        }

        public void DrawCircle(Graphics grafik, int x, int y, int radius, Color color) 
        {
            using (SolidBrush brush = new SolidBrush(color)) 
            {
                grafik.FillEllipse(brush, x - radius, y - radius, 2 * radius, 2 * radius);
            }
        }
	}
}
