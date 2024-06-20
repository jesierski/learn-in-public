// Punkteingaben zwischen 0 und 100 werden zu Noten umgerechnet
using System.Globalization;

Console.WriteLine("Bitte geben Sie eine Zahl zwischen 0 und 100 ein: ");
string Eingabe = Console.ReadLine();
int Zahl = 0;
try
{
    Zahl = int.Parse(Eingabe);
    while (Zahl < 0 || Zahl > 100) 
        {
        Console.WriteLine("Die Zahl ist nicht im Bereich 0 bis 100. Bitte geben Sie erneut eine Zahl ein.");
        Eingabe = Console.ReadLine();
        Zahl = int.Parse(Eingabe);
    }
}
catch (InvalidCastException e)
{
    Console.WriteLine(e.Message);
}
catch (Exception e) 
{ 
    Console.Write(e.StackTrace);
}
String Note = "6";
switch (Zahl) 
{
    case >= 81 and <= 100: Note = "1"; break;
    case >= 71 and <= 80: Note = "2"; break;
    case >= 61 and <= 70: Note = "3"; break;
    case >= 51 and <= 60: Note = "4"; break;
    case >= 1 and <= 50: Note = "5"; break;
    default: Note = "Die " + Note + " ist keine gültige Eingabe."; break;
}
Console.WriteLine("Die Zahl entspricht der Note " + Note);
Console.WriteLine("Möchten Sie den Durchschnitt (float) der Eingabe berechnen (j/n)?");
string Antwort = Console.ReadLine();
if (Antwort == "j") 
{
    Console.WriteLine("Bitte geben Sie ganze Zahl zw. 0 und 100 ein.");
    string Eingabe2 = Console.ReadLine();
    float Zahl2 = 0.0f;
    try
    {
        Zahl2 = float.Parse(Eingabe2, CultureInfo.InvariantCulture);
        Console.WriteLine("Eingegeben wurde: " + Zahl2);
        while (Zahl2 < 0 || Zahl2 > 100) 
        {
            Console.WriteLine("Die Zahl ist nicht im Bereich 0 bis 100. Bitte geben Sie erneut eine Zahl ein.");
            Eingabe2 = Console.ReadLine();
            Zahl2 = float.Parse(Eingabe2);
        }
    }
    catch (InvalidCastException e)
    {
        Console.WriteLine(e.Message);
    }
    catch (Exception e)
    {
        Console.Write(e.StackTrace);
    }
    String Note2 = "6.0";
    switch (Zahl2)
    {
        case >= 81 and <= 100: Note2 = "1.0"; break;
        case >= 71 and <= 80: Note2 = "2.0"; break;
        case >= 61 and <= 70: Note2 = "3.0"; break;
        case >= 51 and <= 60: Note2 = "4.0"; break;
        case >= 1 and <= 50: Note2 = "5.0"; break;
        default: Note2 = Note2 + " ist keine gültige Eingabe."; break;
    }
    float avg = (Zahl + Zahl2)/2;
    Console.WriteLine($"Der Durchschnitt der beiden Zahlen entspricht: {avg}");
}
if (Antwort == "n")
{
    Console.WriteLine("Tschüss!");
    return;
}
if (Antwort != "j" && Antwort != "n") 
{
    Console.WriteLine("Das war keine gültige Antwort. Ich beende jetzt.");
    return;
}
