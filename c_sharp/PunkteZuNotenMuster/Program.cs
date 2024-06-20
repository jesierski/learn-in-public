bool validInput = false;
int punktzahl = 0;
while (!validInput)
{
    Console.WriteLine("Bitte gib eine Punktzahl zwischen 1 und 100 ein:");
    try
    {
        punktzahl = Convert.ToInt32(Console.ReadLine());
        if (punktzahl < 1 || punktzahl > 100)
        {
            Console.WriteLine("Die Punktzahl muss zwischen 1 und 100 liegen.");
        }
        else
        {
            validInput = true;
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Ungültige Eingabe. Bitte gib eine Zahl ein.");
    }
}

int note = BerechneNote(punktzahl);
Console.WriteLine($"Deine Note ist: {note}");

Console.WriteLine("Möchtest du eine weitere Punktzahl eingeben, um den Durchschnitt zu berechnen? (ja/nein)");
string antwort = Console.ReadLine();
if (antwort.ToLower() == "ja")
{
    validInput = false;
    int zweitePunktzahl = 0;
    while (!validInput)
    {
        Console.WriteLine("Bitte gib eine zweite Punktzahl zwischen 1 und 100 ein:");
        try
        {
            zweitePunktzahl = Convert.ToInt32(Console.ReadLine());
            if (zweitePunktzahl < 1 || zweitePunktzahl > 100)
            {
                Console.WriteLine("Die Punktzahl muss zwischen 1 und 100 liegen.");
            }
            else
            {
                validInput = true;
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Ungültige Eingabe. Bitte gib eine Zahl ein.");
        }
    }

    int zweiteNote = BerechneNote(zweitePunktzahl);
    float durchschnitt = (float)(note + zweiteNote) / 2;
    Console.WriteLine($"Der Durchschnitt der Noten ist: {durchschnitt}");
}  
 
    static int BerechneNote(int punktzahl)
{
    if (punktzahl <= 50) return 5;
    else if (punktzahl <= 60) return 4;
    else if (punktzahl <= 70) return 3;
    else if (punktzahl <= 80) return 2;
    else return 1;
}
