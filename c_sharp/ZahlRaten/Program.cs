// Zahl raten
Random random = new Random();
int Zahl = 0;
string Eingabe = "";
int Zufall = random.Next(1, 1000);
Console.WriteLine("########## Ratespiel ##########");
while (Zahl != Zufall)
{
    Console.WriteLine("Rate eine Zahl: ");
    Eingabe = Console.ReadLine();
    Zahl = int.Parse(Eingabe);
    if (Zahl < Zufall) Eingabe = Eingabe + " ist zu klein.";
    if (Zahl > Zufall) Eingabe = Eingabe + " ist zu groß.";
    if (Zahl == Zufall) Eingabe = Eingabe + " ist richtig!";
    Console.WriteLine(Eingabe);
}
Console.WriteLine("Die Zahl ist " + Zufall);

