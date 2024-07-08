using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StimmungsChecker
{
    public partial class Form1 : Form
    {
        private Button gluecklickButton = new Button();
        private Button traurigButton = new Button();
        private Button aufgeregtButton = new Button();
        private Button neutralButton = new Button();
        private ListBox listenfeld = new ListBox();
        private RadioButton gluecklichRadio = new RadioButton();
        private RadioButton traurigRadio = new RadioButton();
        private RadioButton aufgeregtRadio = new RadioButton();
        private RadioButton neutralRadio = new RadioButton();
        private TextBox textbox = new TextBox();

        public Form1()
        {
            this.Text = "StimmungsChecker";

            gluecklickButton.Text = "Glücklich";
            gluecklickButton.Location = new System.Drawing.Point(10, 10);
            
            traurigButton.Text = "Traurig";
            traurigButton.Location = new System.Drawing.Point(10, 50);
            
            aufgeregtButton.Text = "Aufgeregt";
            aufgeregtButton.Location = new System.Drawing.Point(10, 90);
            
            neutralButton.Text = "Neutral";
            neutralButton.Location = new System.Drawing.Point(10, 130);

            listenfeld.Text = "Stimmungen";
            listenfeld.Size = new Size(60, 60);
            listenfeld.Location = new System.Drawing.Point(100, 10);
            listenfeld.Items.Add("Glücklich");
            listenfeld.Items.Add("Traurig");
            listenfeld.Items.Add("Aufgeregt");
            listenfeld.Items.Add("Neutral");

            gluecklichRadio.Text = "Glücklich";
            gluecklichRadio.Location = new System.Drawing.Point(100, 70);

            traurigRadio.Text = "Traurig";
            traurigRadio.Location = new System.Drawing.Point(100, 90);

            aufgeregtRadio.Text = "Aufgeregt";
            aufgeregtRadio.Location = new System.Drawing.Point(100, 110);

            neutralRadio.Text = "Neutral";
            neutralRadio.Location = new System.Drawing.Point(100, 130);

            textbox.Location = new System.Drawing.Point(10,175);
            textbox.Size = new Size(180,25);

            this.Controls.Add(gluecklickButton);
            this.Controls.Add(traurigButton);
            this.Controls.Add(aufgeregtButton);
            this.Controls.Add(neutralButton);
            this.Controls.Add(listenfeld);
            this.Controls.Add(gluecklichRadio);
            this.Controls.Add(traurigRadio);
            this.Controls.Add(aufgeregtRadio);
            this.Controls.Add(neutralRadio);
            this.Controls.Add(textbox);


            gluecklickButton.Click += (sender, e) => textbox.Text = "Glücklich";

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gluecklich name = new Gluecklich();            
            textBox1.Text = name.ausgeben();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Traurig name = new Traurig();
            listBox1.Text = name.ausgeben();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Aufgeregt name = new Aufgeregt();
            listBox1.Text = name.ausgeben();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Neutral name = new Neutral();
            listBox1.Text = name.ausgeben();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
