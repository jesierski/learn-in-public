// Textabenteuerspiel
Console.WriteLine("Willkommen zum Textabenteuerspiel!");
Console.WriteLine("Wie heißt du?");
string Name = Console.ReadLine();
Console.WriteLine(Name + ", schön dass du hier bist! Lass uns beginnen.");

// Szenarien
int[] Zauberer = { 9 };
int[] Drache = { 2, 5, 7, 8 };
int[] Troll = { 1, 3, 6, 10 };
int[] Balrog = { 4 };

// Fragen, Antworten
int[] AlterDrache = { 132, 494, 249, 105, 398, 989 };
    

// Variablen
int Laufvariable = 0;
bool weiterfragen = true;
bool spielen = true;

float Ergebnis = 0;
int TippAlter = 0;
int WahresAlter = 0;
int Zahl = 0;

while (spielen && Laufvariable < 3)
{
    weiterfragen = true; spielen = false;
    Console.WriteLine("Bitte gib eine Zahl zwischen 1 und 10 ein: ");
    try
    {
        // Abenteuerpfad wird erzeugt
        Zahl = int.Parse(Console.ReadLine());
        int[] Pfad = new int[15];
        Random Zufall = new Random(Zahl);
        for (int i = 0; i < 15; i++) 
        {
            Pfad[i] = Zufall.Next(1, 10);
        }

        // Der Abenteuerpfad wird abgelaufen
        for (int i = 0; i < Pfad.Length; i++)
        {
            // Basierend auf Zahl Szenario auswählen
            if (Zauberer.Contains(Pfad[i]))
            {
                Console.WriteLine("Freundlicher Zauberer");
                Console.WriteLine("Hier passiert nichts.");
            }
            else if (Drache.Contains(Pfad[i]))
            {
                Console.WriteLine("Drache");
                Console.WriteLine("Wie alt ist der Drache ungefähr? 5x darfst du raten.");
                bool nochmal = true;
                int Zaehler = 0;
                WahresAlter = AlterDrache[Laufvariable];

                while (nochmal && (Zaehler < 5))
                {
                    try
                    {                       
                        TippAlter = int.Parse(Console.ReadLine());
                        float Diff = BerechneDiff(WahresAlter, TippAlter);
                        Zaehler++;

                        if (Diff > 100) Console.WriteLine("Weit weg! Probier es nochmal.");
                        else if ((Diff >= 50) && (Diff < 100)) Console.WriteLine("Schon nahe dran.");
                        else if ((Diff >= 10) && (Diff < 50)) Console.WriteLine("Fast getroffen.");
                        else
                        {
                            Console.WriteLine("Super, fast erraten. Genaues Alter: " + WahresAlter);
                            Laufvariable++;
                            nochmal = false;
                            Zaehler = 6;
                        }

                        if (Zaehler == 5) 
                        {
                            Console.WriteLine("Der Drache ist " + WahresAlter + " Jahre alt.");
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Bitte gib eine ganze Zahl ein.");
                    }
                }
            }
            else if (Troll.Contains(Pfad[i]))
            {
                Console.WriteLine("Troll");
                Console.WriteLine("Wie weit kann ich werfen?");
                try
                {
                    int TippWurf = int.Parse(Console.ReadLine());
                    Console.WriteLine("Wow! " + "Ich wusste gar nicht, dass ich so weit werfen kann: " + BerechneWeite(TippWurf) + "m");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Bitte gib eine ganze Zahl ein.");
                }
            }
            else if (Balrog.Contains(Pfad[i]))
            { 
                Console.WriteLine("Balrog");
                Console.WriteLine("Der Balrog ist unbesiegbar!");
                Console.WriteLine("Das Spiel ist hier beendet.");
                Thread.Sleep(5000);
                Laufvariable = 3;
                i = Pfad.Length;
            }
            else { Console.WriteLine("Huch, hier ist ein unbekanntes Abenteuer."); }
            Console.WriteLine("-------------------------------");
            // Zaehle diesen Durchlauf
            Laufvariable++;
        }
    }
    catch (FormatException e)
    {
        Console.WriteLine(e.Message);
    }

    while (weiterfragen && Laufvariable < 3) 
    {
        weiterfragen = false;
        Console.WriteLine("Weiterspielen (Ja/Nein)?");
        string antwort = Console.ReadLine();

        if (antwort == "Ja" || antwort == "Nein")
        {
            if (antwort == "Ja") { Console.WriteLine("Eine gute Wahl!"); spielen = true; }
            if (antwort == "Nein") { Console.WriteLine("Schade."); }
        }
        else
        {
            Console.WriteLine("Wie bitte? Wiederhole."); weiterfragen = true;
        }
    }
}

// Berechnungsfunktionen
static float BerechneDiff(int Alter, int Tipp) 
{
    float ErgebnisModifiziert = (float)(Tipp + 0.5);
    float Differenz = Math.Abs(Alter - ErgebnisModifiziert);
    return Differenz;
}

static float BerechneWeite(int Tipp) 
{
    float Wurf = (float)(Tipp*0.4);
    return Wurf;
}