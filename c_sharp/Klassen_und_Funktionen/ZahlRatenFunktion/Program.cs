// Spiel Zahl raten umgesetzt über Funktionen

// Globale Variablen
Random random = new Random();
int Versuche = 0; int Zahl = 0;
string Eingabe = "";

//Funktionen
int InitGame() 
{
    int Zufall = random.Next(1,1000);
    return Zufall;
}

void PlayGame(int Zufall) 
{
    while (Zahl != Zufall)
    {
        Console.WriteLine("Rate eine Zahl: ");
        Eingabe = Console.ReadLine();
        Zahl = int.Parse(Eingabe);
        if (Zahl < Zufall) Eingabe = Eingabe + " ist zu klein.";
        if (Zahl > Zufall) Eingabe = Eingabe + " ist zu groß.";
        if (Zahl == Zufall) Eingabe = Eingabe + " ist richtig!";
        Console.WriteLine(Eingabe);
        Versuche++;
    }
}

void FinishGame(int Zufall) 
{
    Console.WriteLine("Die Zahl ist " + Zufall);
    Console.WriteLine("Das waren " + Versuche + " Versuche");
}

// Hauptprogramm
int ZufallHaupt = InitGame();
PlayGame(ZufallHaupt);
FinishGame(ZufallHaupt);
