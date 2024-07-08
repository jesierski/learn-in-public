using System;
using System.Windows.Forms;

public class MeinFenster : Form
{
    private Label beschriftung;
    private Button nachrichtButton;
    private Button schliessButton;

    public MeinFenster()
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
}
