// See https://aka.ms/new-console-template for more information
Console.WriteLine("Geben Sie einen Zahl zwischen 0 und 100 ein. Das Programm kategorisiert sie dann.");
Console.WriteLine("Mit einer Zahl außerhalb [0,100] beenden Sie das Programm.");
int Zahl = 0;
bool Eingabe = false;
float ZahlDez = 0;

while (!Eingabe && (0 <= Zahl && Zahl <= 100)) 
{

    try
    {
        Zahl = int.Parse(Console.ReadLine());
        if (Zahl < 0 || Zahl > 100)
        {
            Eingabe = true; 
            Console.WriteLine("Danke fürs Kategorisieren.");
            return;
        }
    }
    catch (FormatException) 
    {
        Console.WriteLine("Ungültige Eingabe. Bitte gib eine ganze Zahl zwischen 0 und 100 ein.");
    }

    ZahlDez = (float)(0.5 * Zahl);

    string Text = KategorieZahl(2*ZahlDez); // *2 Sonst ist auch bei Eingabe 100 die Kategorie "Niedrig"
    Console.WriteLine("Die eingegebene Zahl ist: " + Text);
    Console.WriteLine("Bitte geben Sie eine ganze Zahl ein:");
}


static String KategorieZahl(float ZahlDezimal) 
{
    switch (ZahlDezimal)
    {
        case (>= 0 and <= 25): return "Sehr niedrig";
        case ( >= 26 and <= 50): return "Niedrig";
        case (>= 51 and <= 75): return "Hoch";
        case (>= 76 and <= 100): return "Sehr hoch";
        default: return "Nanu?!";
    }
}


