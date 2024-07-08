// Million
string Eingabe = "";
float Zinsen = 0;
Console.WriteLine("Wie viel Geld willst du anlegen?");
Eingabe = Console.ReadLine();
float Kapital = float.Parse(Eingabe);
Console.WriteLine("Wie hoch soll der Zinssatz (mit Komma) sein?");
Eingabe = Console.ReadLine();
float Prozent = float.Parse(Eingabe);
int Laufzeit = 0;
while (Kapital < 1000000) 
{
    Zinsen = Kapital * Prozent / 100;
    Kapital = Kapital + Zinsen;
    Laufzeit++;
}
if (Laufzeit > 0)
    Console.WriteLine("Dein Geld muss " + Laufzeit + " Jahre auf der Bank liegen.");
else 
    Console.WriteLine("Willkommen im Club der Millionäre!");