using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpielSchereSteinPapier
{
    public partial class Form1 : Form
    {
        private Label Anzeige = new Label();
        private PictureBox LBox = new PictureBox();
        private PictureBox RBox = new PictureBox();
        private Random random = new Random();
        private int Links, Rechts;
        private string Pfad = @"D:\git\learn-in-public\c_sharp\SpielSchereSteinPapier\Images\";
        private Bitmap[] Bild = new Bitmap[3];
        private Button Schere = new Button();
        private Button Stein = new Button();
        private Button Papier = new Button();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(770, 500);
            this.Text = "Schere, Stein, Papier";
            CreateLabel();
            CreateButtons();
            CollectImages();
            CreatePictures();
            this.Controls.Add(Anzeige);
            this.Controls.Add(LBox);
            this.Controls.Add(RBox);
            this.Controls.Add(Schere);
            this.Controls.Add(Stein);
            this.Controls.Add(Papier);

        }

        private void CreateLabel() 
        {
            Anzeige.BorderStyle = BorderStyle.FixedSingle;
            Anzeige.Location = new Point(80,25);
            Anzeige.Size = new Size(580, 50);
            Anzeige.Font = new Font("Arial", 14F);
            Anzeige.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void CreateButtons() 
        {
            // Button Schere
            Schere.Location = new Point(100, 380);
            Schere.Size = new Size(150, 50);
            Schere.Font = new Font("Arial", 14F);
            Schere.Text = "Schere";
            Schere.Click += new EventHandler(button1_Click);
            // Button Stein
            Stein.Location = new Point(270, 380);
            Stein.Size = new Size(150, 50);
            Stein.Font = new Font("Arial", 14F);
            Stein.Text = "Stein";
            Stein.Click += new EventHandler(button2_Click);
            // Button Papier
            Papier.Location = new Point(440, 380);
            Papier.Size = new Size(150, 50);
            Papier.Font = new Font("Arial", 14F);
            Papier.Text = "Papier";
            Papier.Click += new EventHandler(button3_Click);
        }

        private void CreatePictures() 
        {
            LBox.BorderStyle = BorderStyle.FixedSingle;
            RBox.BorderStyle = BorderStyle.FixedSingle;
            LBox.Location = new Point(50, 105);
            RBox.Location = new Point(380, 105);
            LBox.Size = new Size(320, 240);
            RBox.Size = new Size(320, 240);
            LBox.SizeMode = PictureBoxSizeMode.StretchImage;
            RBox.SizeMode = PictureBoxSizeMode.StretchImage;
            LBox.Visible = true;
            RBox.Visible = true;
        }

        public void CollectImages() 
        {
            try
            {
                Bild[0] = (Bitmap)Image.FromFile(Pfad + "schere.jpg");
                Bild[1] = (Bitmap)Image.FromFile(Pfad + "stein.jpg");
                Bild[2] = (Bitmap)Image.FromFile(Pfad + "papier.png");
            }
            catch (Exception)
            {
                MessageBox.Show("Kein Bild!");
            }
        }

        public void ShowImages() 
        {
            Rechts = random.Next(0, 3);
            LBox.Image = Bild[Links];
            RBox.Image = Bild[Rechts];
        }

        public void Evaluate() 
        {
            string Ergebnis = "unentschieden";
            if (Links == 0 && Rechts == 1) 
                Ergebnis = "Du hast verloren"; // Schere-Stein
            if (Links == 1 && Rechts == 2) 
                Ergebnis = "Du hast verloren"; // Stein-Papier
            if (Links == 2 && Rechts == 0) 
                Ergebnis = "Du hast verloren"; // Papier-Schere
            if (Links == 0 && Rechts == 2) 
                Ergebnis = "Du hast gewonnen"; // Schere-Papier
            if (Links == 1 && Rechts == 0) 
                Ergebnis = "Du hast gewonnen"; // Stein-Schere
            if (Links == 2 && Rechts == 1) 
                Ergebnis = "Du hast gewonnen"; // Papier-Stein
            Anzeige.Text = Ergebnis;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Links = 0;
            ShowImages();
            Evaluate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Links = 1;
            ShowImages();
            Evaluate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Links = 2;
            ShowImages();
            Evaluate();
        }
    }
}
