// Klassen für die Mitarbeiterverwaltung
public class Mitarbeiter 
{
    // Attribute der Klasse Mitarbeiter
    public int MitarbeiterID { get; set; }
    public string Name { get; set; }
    public string Position { get; set; }
    public double Gehalt { get; set; }

    // Konstruktor der Klasse Mitarbeiter
    public Mitarbeiter(int mitarbeiterid, string name, string position, double gehalt)
    {
        MitarbeiterID = mitarbeiterid;
        Name = name;
        Position = position;
        Gehalt = gehalt;
    }

    // Methoden in der Klasse Mitarbeiter
    public void AktualisiereName(string neuerName) 
    { 
        Name = neuerName;
    }

    public void AktualisierePosition(string neuePosition) 
    { 
        Position = neuePosition;
    }

    public void AktualisiereGehalt(double neuesGehalt) 
    { 
        Gehalt = neuesGehalt;
    }

}

public class MitarbeiterVerwaltung
{
    //// Attribute der  Klasse MitarbeiterVerwaltung
    //List<Mitarbeiter> ListeMitarbeiter;

    //// Konstruktor der Klasse MitarbeiterVerwaltung
    //public MitarbeiterVerwaltung(List<Mitarbeiter> listeMitarbeiter) 
    //{
    //    ListeMitarbeiter = listeMitarbeiter;
    //}

    private List<Mitarbeiter> ListeMitarbeiter = new List<Mitarbeiter>();

    // Methoden
    // Hinzufügen eines Mitarbeiters
    public void MitarbeiterHinzufuegen(Mitarbeiter mitarbeiter) 
    {
        ListeMitarbeiter.Add(mitarbeiter);
    }

    // Aktualisieren der Daten eines Mitarbeiters
    public void MitarbeiterAktualisieren(int mitarbeiterid, string name, string position, double gehalt) 
    {
        foreach (Mitarbeiter mitarbeiter in ListeMitarbeiter) 
        {
            if (mitarbeiter.MitarbeiterID == mitarbeiterid)
            {
                mitarbeiter.Name = name;
                mitarbeiter.Position = position;
                mitarbeiter.Gehalt = gehalt;
                break;
            }
            else 
            {
                Console.WriteLine("Dieser Mitarbeiter existiert nicht.");
                break;
            }
        }
    }

    // Löschen eines Mitarbeiters
    public void MitarbeiterLoeschen(int mitarbeiterid) 
    {
        foreach (Mitarbeiter mitarbeiter in ListeMitarbeiter.ToList()) 
        {
            if (mitarbeiter.MitarbeiterID == mitarbeiterid) 
            {
                ListeMitarbeiter.Remove(mitarbeiter);
            }
        }
    }

    // Alle Mitarbeiter anzeigen
    public void MitarbeiterAnzeigen() 
    {
        Console.WriteLine("Alle Mitarbeiter des Unternehemens: ");
        Console.WriteLine("----------------------------------------------------");
        foreach (Mitarbeiter mitarbeiter in ListeMitarbeiter) 
        {
            Console.Write(
                "Mitarbeiter-ID: " + mitarbeiter.MitarbeiterID + ", " +
                "Name: " + mitarbeiter.Name + ", " +
                "Position: " + mitarbeiter.Position + ", " +
                "Gehalt: " + mitarbeiter.Gehalt);
        }
        Console.WriteLine("----------------------------------------------------");
    }
}