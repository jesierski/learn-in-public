/* d) Implementiere in der Main-Methode die Erstellung von mindestens zwei Klassen 
 * mit jeweils einem Klassenlehrer und mehreren Schülern. 
 * Demonstriere die Funktionalität des Systems, indem du Schülern Noten zuweist und diese Noten ausgibst.  
*/

// Verwaltung einer Schule
Console.WriteLine("#####################################################");
Console.WriteLine("################## Schulverwaltung ##################");
Console.WriteLine("#####################################################");

//Hauptprogramm
// Füge einige Lehrer hinzu
Lehrer l1 = new Lehrer("Michael Orowitz", 1, "Mathematik");
Lehrer l2 = new Lehrer("Christine Meier", 2, "Deutsch");
Lehrer l3 = new Lehrer("Maro Titian", 9, "Kunst");

// Füge Schülerlisten hinzu, um Schüler aufzunehmen
List<Schueler> liste1 = new List<Schueler>();
List<Schueler> liste2 = new List<Schueler>();
List<Schueler> liste3 = new List<Schueler>();

// Instanziiere Klassen mit jeweils einem Klassenlehrer und einer Liste von Schülern
Klasse ersteKlasse = new Klasse("5a", l1, liste1);
Klasse zweiteKlasse = new Klasse("4b", l2, liste2);
Klasse dritteKlasse = new Klasse("5c", l3, liste3);

// Definiere Dictionaries für Schüler, um den Schülern Noten zuzuweisen
Dictionary<string, int> s1_d = new Dictionary<string, int>();
s1_d.Add("Mathematik", 1);
s1_d.Add("Deutsch", 3);
s1_d.Add("Musik", 1);
s1_d.Add("Kunst", 2);
// Instanziiere Schüler
Schueler s1 = new Schueler("Otto Klein", 3, s1_d);

Dictionary<string, int> s2_d = new Dictionary<string, int>();
s2_d.Add("Mathematik", 5);
s2_d.Add("Deutsch", 3);
s2_d.Add("Musik", 3);
s2_d.Add("Kunst", 2);
Schueler s2 = new Schueler("Hermann Minne", 4, s2_d);

Dictionary<string, int> s3_d = new Dictionary<string, int>();
s3_d.Add("Mathematik", 2);
s3_d.Add("Deutsch", 1);
s3_d.Add("Musik", 2);
s3_d.Add("Kunst", 1);
Schueler s3 = new Schueler("Lise Schmidt", 5, s3_d);

Dictionary<string, int> s4_d = new Dictionary<string, int>();
s4_d.Add("Mathematik", 2);
s4_d.Add("Deutsch", 4);
s4_d.Add("Musik", 2);
s4_d.Add("Kunst", 3);
Schueler s4 = new Schueler("Julia Müller", 6, s4_d);

Dictionary<string, int> s5_d = new Dictionary<string, int>();
s5_d.Add("Mathematik", 4);
s5_d.Add("Deutsch", 3);
s5_d.Add("Musik", 3);
s5_d.Add("Kunst", 3);
Schueler s5 = new Schueler("Benno Groß", 7, s5_d);

Dictionary<string, int> s6_d = new Dictionary<string, int>();
s6_d.Add("Mathematik", 3);
s6_d.Add("Deutsch", 2);
s6_d.Add("Musik", 1);
s6_d.Add("Kunst", 2);
Schueler s6 = new Schueler("Finn Klein", 8, s6_d);

// Gib die erste Klasse mit ihren Schülern aus
Console.WriteLine("-----------------------------------------------------");
Console.Write("Klasse: " + ersteKlasse.Klassenname + ", ");
Console.WriteLine("Klassenlehrer: " + ersteKlasse.Klassenlehrer.Name);
Console.WriteLine("-----------------------------------------------------");
// Schüler zur Klasse Klasse hinzufügen und ausgeben
ersteKlasse.SchuelerHinzufuegen(s1);
ersteKlasse.SchuelerHinzufuegen(s4);
ersteKlasse.SchuelerHinzufuegen(s6);
foreach (Schueler s in ersteKlasse.Schuelerliste)
{
    Console.WriteLine("Schüler: " + s.Name.ToString() + " (ID: " + s.ID.ToString() + ")");
    foreach (KeyValuePair<string, int> note in s.Noten)
    {
        Console.Write(note.Key + ": " + note.Value + "; ");
    }
    Console.WriteLine("\n\r");
}

// Gib die zweite Klasse mit ihren Schülern aus
Console.WriteLine("-----------------------------------------------------");
Console.Write("Klasse: " + zweiteKlasse.Klassenname + ", ");
Console.WriteLine("Klassenlehrer: " + zweiteKlasse.Klassenlehrer.Name);
Console.WriteLine("-----------------------------------------------------");
// Schüler zur Klasse Klasse hinzufügen und ausgeben
zweiteKlasse.SchuelerHinzufuegen(s2);
zweiteKlasse.SchuelerHinzufuegen(s3);
foreach (Schueler s in zweiteKlasse.Schuelerliste)
{
    Console.WriteLine("Schüler: " + s.Name.ToString() + " (ID: )" + s.ID.ToString() + ")");
    foreach (KeyValuePair<string, int> note in s.Noten)
    {
        Console.Write(note.Key + ": " + note.Value + "; ");
    }
    Console.WriteLine("\n\r");
}

// Gib die dritte Klasse mit ihren Schülern aus
Console.WriteLine("-----------------------------------------------------");
Console.Write("Klasse: " + dritteKlasse.Klassenname + ", ");
Console.WriteLine("Klassenlehrer: " + dritteKlasse.Klassenlehrer.Name);
Console.WriteLine("-----------------------------------------------------");
// Schüler zur Klasse Klasse hinzufügen und ausgeben
dritteKlasse.SchuelerHinzufuegen(s5);
foreach (Schueler s in dritteKlasse.Schuelerliste)
{
    Console.WriteLine("Schüler: " + s.Name.ToString() + " (ID: " + s.ID.ToString() + ")");
    foreach (KeyValuePair<string, int> note in s.Noten)
    {
        Console.Write(note.Key + ": " + note.Value + "; ");
    }
    Console.WriteLine("\n\r");
}
