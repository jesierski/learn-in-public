//Lotto
Console.WriteLine("");
Console.WriteLine("LOTTO 6 aus 49");
const int Max = 49;
const int Anzahl = 6;
Random random = new Random();
int[] Lottozahl = new int[Max + 1];
int Zufall = 0;
for (int i = 1; i < Lottozahl.Length; i++)
{
    Lottozahl[i] = 0;
}
// 6 Zahlen ziehen
for (int Nr = 1; Nr <= Anzahl; Nr++)
// Zufallszahl suchen (noch nicht verwendet)
{
    do
    {
        Zufall = random.Next(1, Max);
    }
    while (Lottozahl[Zufall] == 1);
    // Benutzer Zahl als gezogen markieren
    Lottozahl[Zufall] = 1;
    // Gezogene Zahle anzeigen
    Console.WriteLine(Nr + ". Ziehung: " + Zufall);
}