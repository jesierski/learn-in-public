using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kundenverwaltung
{
    public partial class KundenverwaltungForm : Form
    {
        private List<Kunde> Kunden = new List<Kunde>();

        public KundenverwaltungForm()
        {
            InitializeComponent();
            Kunde kunde1 = new Kunde("Max", "Mustermann", "Hauptstr.2", "12345 Berlin", 987532);
            Kunde kunde2 = new Kunde("Meike", "Müller", "Niederstr. 43", "76538 Oberursel", 01557684);
            Kunde kunde3 = new Kunde("Irene", "Schmidt", "Mainzstr. 54", "86428 Niederbayern", 78923634);
            Kunde kunde4 = new Kunde("Ingo", "Meyer", "Große Allee 7", "01345 Hamburg", 85232345);
            Kunde kunde5 = new Kunde("Susanne", "Leicht", "Obere Straße 8", "76409 Muttendorf", 013573365);
            List<Kunde> startkunden = new List<Kunde>() { kunde1, kunde2, kunde3, kunde4, kunde5};
            foreach (Kunde neukunde in startkunden)
            {
                Kunden.Add(neukunde);
            }
            AktualisiereListBox();
            //listBox1.SetSelected(listBox1.TopIndex, true);
        }

        private void KundenverwaltungForm_Load(object sender, EventArgs e)
        {
            AktualisiereListBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Dialog anzeigen zur Eingabe eines neuen Kunden
            using (var dialog = new Dialog()) 
            {
                var result = dialog.ShowDialog();
                if (result == DialogResult.OK) 
                {
                    // Neuen Kunden zur Kundenliste hinzufügen
                    Kunde kunde = dialog.ReturnKunde;
                    Kunden.Add(kunde);
                    // Neuen Kunden in der Listbox anzeigen
                    AktualisiereListBox();

                    //listBox1.SelectedIndex = listBox1.Items.Count - 1;
                    //listBox1.SetSelected(listBox1.Items.Count - 1, true);
                    listBox1.SetSelected(listBox1.TopIndex, true);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Je nach in listBox1 ausgewählem Item das Panel aktualisieren
            int eintrag = listBox1.SelectedIndex;
            Kunde kunde = Kunden[eintrag];
            textBox1.Text = kunde.Vorname;
            textBox2.Text = kunde.Nachname;
            textBox3.Text = kunde.Adresse;
            textBox4.Text = kunde.PLZ_Ort;
            textBox5.Text = kunde.Tel.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int nr = listBox1.SelectedIndex;

            if (nr >= 0)
            {
                Kunde ausgewaehlterKunde = Kunden[nr];
                Kunden.Remove(ausgewaehlterKunde);
                listBox1.Items.RemoveAt(nr);
                AktualisiereListBox();
            }
        }

        // Helfer-Methoden
        private void AktualisiereListBox() 
        {
            // Kunden in listBox1 anzeigen
            listBox1.Items.Clear();
            foreach (var kunde in Kunden) 
            {
                listBox1.Items.Add(
                    kunde.Vorname + " " + 
                    kunde.Nachname + ", " +
                    kunde.Adresse + ", " +
                    kunde.PLZ_Ort + ", " +
                    kunde.Tel);
            }
        }
    }
}
