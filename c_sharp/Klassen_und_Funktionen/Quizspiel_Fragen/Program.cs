// Quizspiel Fragen
Console.WriteLine("##################### Quizspiel #####################");

/* a) Initialisierung (InitGame): In dieser Funktion sollst du 
 * eine Liste von Fragen und die zugehörigen Antworten initialisieren. 
 * Jede Frage ist ein String und jede Antwort ist ein boolscher Wert (true oder false). 
 * Verwende lokale Variablen, um die Fragen und Antworten zu speichern.  */

(string[], bool[]) InitGame()
{
    string[] strings = {
        "Die Hauptstadt von Belgien ist Brüssel.",
        "Der höchste Berg ist der Mount Everest",
        "Die tiefste Stelle unter dem Meeresspiegel ist 9.220 m tief.",
        "Der Regenbogen hat 7 Farben.",
        "Der größte Vogel der Welt ist der Albatros."};

    bool[] bools = { true, true, false, true, false };

    return (strings, bools);
}

/* b) Spiellogik (PlayGame): Diese Funktion nimmt die Liste der Fragen und Antworten 
  * als Parameter entgegen. Für jede Frage soll das Programm den Nutzer um Eingabe bitten 
  * (true oder false). Vergleiche die Nutzereingabe mit der tatsächlichen Antwort. 
  * Zähle, wie viele Antworten der Nutzer richtig hat. Verwende lokale Variablen, 
  * um die Nutzereingaben und die Anzahl der richtigen Antworten zu speichern. */


// Als globale Variable Zaehler
int Zaehler = 0;
void PlayGame((string[] strings, bool[] bools) Paare)
{
    // Als lokale Variable Zaehler 
    //int Zaehler = 0;

    // Schleife von 1 bis Länge der Fragenliste
    for (int i = 0; i < Paare.Item1.Length; i++)
    {
        Console.WriteLine(Paare.Item1[i]);
        bool weiter = true;
        while (weiter) {
            try
            {
                Console.WriteLine("Ist die Behauptung richtig oder falsch (true oder false)?");
                bool antwort = bool.Parse(Console.ReadLine());
                if (antwort == Paare.Item2[i])
                {
                    Console.WriteLine("Das war richtig!"); Zaehler++; break;
                }
                else 
                {
                    Console.WriteLine("Das war leider nicht richtig.");
                }
                weiter = false;
            } 
            catch (Exception e)
            {
                Console.WriteLine("Die Eingabe war nicht im Format true oder false.");
                Console.WriteLine("Bitte gib 'true' oder 'false' ein. Ohne Anführungsstriche.");
            }
        }
    }
    // Bei lokaler Variable Zaehler
    //return Zaehler; 
}

/* c) Ergebnisausgabe (ShowResults): Diese Funktion nimmt die 
 * Anzahl der richtigen Antworten als Parameter und gibt das Ergebnis aus 
 * (z.B. "Du hast 3 von 5 Fragen richtig beantwortet!").
 */

void ShowResults(int Zahl) 
{
    Console.WriteLine($"Du hast {Zahl} von 5 Fragen richtig beantwortet!");
}

// Hauptprogramm

// Bei ausschließlich lokalen Variablen
//ShowResults(PlayGame(InitGame());

// Mit globaler Variable Zaehler
PlayGame(InitGame());
ShowResults(Zaehler);