// Quizspiel mind. 3 Fragen über Klassen und Funktionen umgesetzt
Console.WriteLine("############ Quizspiel mit Funktion und Klassen ############");




// Hauptprogramm
/* c) Im Hauptprogramm (Main-Methode) soll eine Liste von Frage-Objekten erstellt werden. 
 * Füge mindestens drei Fragen hinzu und 
 * rufe für jede Frage die Methode StelleFrage() auf. */

int korrekt = 0;
List<Frage> fragen = new List<Frage>();

string text1 = "Wie heißt die Hauptstadt von Belgien?";
string[] liste1 = { "Amsterdam", "Paris", "Brüssel", "Luxembourg" };
string antwort1 = "3";
Frage frage1 = new Frage(text1, liste1, antwort1);
fragen.Add(frage1);

string text2 = "Wie tief ist die tiefste Stelle der Erde ab Meeresspiegel?";
string[] liste2 = { "11.020 m", "9.220 m", "8.870 m", "4.500 m" };
string antwort2 = "1";
Frage frage2 = new Frage(text2, liste2, antwort2);
fragen.Add(frage2);

string text3 = "Welcher ist der größte Vogel der Welt?";
string[] liste3 = { "europäische Gans", "afrikanische Strauß", "Albatros", "Andenkondor" };
string antwort3 = "2";
Frage frage3 = new Frage(text3, liste3, antwort3);
fragen.Add(frage3);

foreach (Frage frage in fragen) 
{
    if (frage.StelleFrage()) 
    {
        korrekt++;
    }
}

Console.WriteLine($"Du hast {korrekt} Antworten von insgesamt {fragen.Count} Fragen.");

if (korrekt >= 2) Console.WriteLine("Du hast bestanden!");
else Console.WriteLine("Diesmal hat es leider nicht gereicht.");
Thread.Sleep(3000);

