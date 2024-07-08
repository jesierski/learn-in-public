// Quiz mit 5 Fragen, jede hat 4 Antworten, nur 1 richtige
using System.ComponentModel;
using System.Runtime.Serialization.Formatters;

Console.WriteLine("Hallo Quiz-Sieler!");
Console.Write("Hier kommen bis zu 5 Fragen, jede mit 4 Antworten. ");
Console.WriteLine("Doch nur 1 ist die richtige. Weißt du welche?");
Console.WriteLine("------------------------------------------------");

String[] arrFragen = {
        "Wie heißt die Hauptstadt von Belgien? A) Amsterdam B) Paris C) Brüssel D) Luxembourg",
        "Welches ist der höchste Berg? A) Zugspitze B) Mount Everst C) Kilimandscharo D) Nanga Parbat",
        "Wie tief ist die tiefste Stelle der Erde ab Meeresspiegel? A) 11.020 m B) 9.220 m C) 8.870 m D) 4.500 m",
        "Wie viele Farben hat der Regenbogen? A) 3 B) 8 C) 7 D) 6",
        "Wie groß ist der größte Vogel der Welt? A) europäische Gans B) afrikanische Strauß C) Albatros D) Andenkondor"};
char[] arrAntworten = { 'c', 'b', 'a', 'c', 'b' };
int[] schwierigkeiten = { 1, 3, 2, 5, 4 };
int counter = 1;

for (int i = 0; i<arrFragen.Length; i++) 
{
    bool wdh = true;
    while (wdh) { 
        Console.WriteLine(arrFragen[i]);
        try
        {
            // Eingabe einlesen
            String eingabe = Console.ReadLine();
            char eingabeA = Char.ToUpper(Console.ReadKey().KeyChar);// Frisst Rechenleistung!!
            try
            {
                if (eingabeA < 'A' || eingabeA > 'D') throw new Exception("Ungültige Eingabe.");
            }
            catch { }
                if (eingabe == "0") break;
                else 
                {
                    // War die Antwort richtig?
                    if (char.Parse(eingabe.ToLower()) == arrAntworten[i])
                    {
                        Console.WriteLine("Das war richtig!");
                    }
                    else
                    {
                        Console.WriteLine("Das war nicht richtig.");
                    }
                    Console.WriteLine("Counter: " + counter);
                    counter++;
                    wdh = false;
                }
        }
        catch (Exception)
        {
            Console.WriteLine($"Die Eingabe war weder A, B, C noch D.");
            wdh = true;
        }
    }
}
Console.WriteLine($"Das Ergebnis ist: {counter} von 5");

// Ausgabe der Fragen nach Schwierigkeit
Console.WriteLine("Schwierigkeiten der Fragen:");
for (int i = 0; i< arrFragen.Length; i++)
{
    Console.Write($"Fragen: {arrFragen[schwierigkeiten[i]-1]} - \nAntworten: {arrAntworten[schwierigkeiten[i]-1]}");
}
