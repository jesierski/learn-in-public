using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlassenZumFormularII
{
    public partial class Form1 : Form
    {
        private Label beschriftung;
        private Button nachrichtButton;
        private Button schliessButton;

        public Form1()
        {
            this.Text = "Mein Programm";
            this.beschriftung = new Label();
            beschriftung.Text = "Bitte einen Button drücken";
            beschriftung.Location = new System.Drawing.Point(10, 20);
            beschriftung.Size = new System.Drawing.Size(200, 20);

            this.nachrichtButton = new NachrichtButton();
            nachrichtButton.Text = "Nachricht";
            nachrichtButton.Location = new System.Drawing.Point(10, 50);

            this.schliessButton = new SchliessButton();
            schliessButton.Text = "Schließen";
            schliessButton.Location = new System.Drawing.Point(10, 80);

            this.Controls.Add(beschriftung);
            this.Controls.Add(nachrichtButton);
            this.Controls.Add(schliessButton);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
