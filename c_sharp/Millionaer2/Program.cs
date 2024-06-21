// Millionaer2

// Deklaration der Variablen
string Eingabe = "";
float Zinsen = 0;

// Eingaben des Nutzers
Console.WriteLine("Wie viel Geld willst du anlegen?");
Eingabe = Console.ReadLine();
float Kapital = float.Parse(Eingabe);
Console.WriteLine("Wie hoch soll der Zinssatz (mit Komma) sein?");
Eingabe = Console.ReadLine();
float Prozent = float.Parse(Eingabe);
Console.WriteLine("Wie lang willst du warten?");
Eingabe = Console.ReadLine();
int Laufzeit = int.Parse(Eingabe);

// Berechnung
for (int Nr = 0; Nr < Laufzeit; Nr++) 
{
    Zinsen = Kapital * Prozent / 100;
    Kapital = Kapital + Zinsen;
}

Console.WriteLine("Du hast " + Kapital + " Euro auf dem Konto.");