/* a) Definiere eine Klasse Mitarbeiter mit den Eigenschaften 
 * Name (string), ID (int), Abteilung (string) und Gehalt (double). 
 * Implementiere einen Konstruktor, der alle diese Eigenschaften initialisiert. */

using System;
using System.Xml.Linq;

public class Mitarbeiter
{
	// Attribute von Mitarbeiter
	public string Name;
	public int ID;
	public string Abteilung;
	public double Gehalt;

	// Konstruktor von Mitarbeiter
	public Mitarbeiter(string Name, int ID, string Abteilung, double Gehalt)
	{
		this.Name = Name;
		this.ID = ID;
		this.Abteilung = Abteilung;
		this.Gehalt = Gehalt;
	}

	/* b) Füge der Klasse Mitarbeiter eine Methode ZeigeDetails() hinzu, 
     * die die Details des Mitarbeiters auf der Konsole ausgibt. */
	public virtual void ZeigeDetails() 
	{
		Console.WriteLine("Name: " + Name);
		Console.WriteLine("ID: " + ID);
		Console.WriteLine("Abteilung: " + Abteilung);
		Console.WriteLine("Gehalt: " + Gehalt);
	}
}

/* c) Erstelle eine weitere Klasse Manager, die von Mitarbeiter erbt und 
 * eine zusätzliche Eigenschaft Bonus (double) hat. 
 * Überschreibe die Methode ZeigeDetails(), sodass sie 
 * zusätzlich den Bonus des Managers ausgibt. 
 */
public class Manager : Mitarbeiter
{
	// Attribut zusätzlich zu Mitarbeiter
	private double Bonus;

	// Konstruktor der Klasse Mitarbeiter
	public Manager(string Name, int ID, string Abteilung, double Gehalt, double Bonus) : base(Name, ID, Abteilung, Gehalt)
	{ 
		this.Bonus = Bonus;
	}

    // Methode ZeigeDetails überschreibt Methode der Elternklasse
    public override void ZeigeDetails()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("ID: " + ID);
        Console.WriteLine("Abteilung: " + Abteilung);
        Console.WriteLine("Gehalt: " + Gehalt);
		Console.WriteLine("Bonus: " + Bonus);
    }
}
