// Schleifen über Konsole anbieten
using System.ComponentModel.Design;
using System.Xml.Linq;

Console.WriteLine("Wähle zwischen folgenden Aktionen: ");
Console.WriteLine("1) Eingabe von 10 Integers und diese dann aufsteigend sortieren. Array speichern.");
Console.WriteLine("2) Eingabe von 1 Integer und Prüfung, ob Zahl im gespeicherten Array vorhanden ist.");
Console.WriteLine("3) Eingabe von 5 Zeichenketten und Ausgabe in umgekehrter Reihenfolge.");
Console.WriteLine("4) Beenden.");

int[] arrayZahlen = new int[10];
string[] arrayZeichen = new string[5];
bool b = true;

while (b) 

{
    try
    {
        Console.WriteLine("Bitte gib deine Wahl (1, 2, 3, 4) ein:");
        string eingabe = Console.ReadLine();

        switch (eingabe)
        {
            case "1":
                {
                    Console.WriteLine("Bitte gib 10 Zahlen ein: ");
                    for (int i = 0; i < 10; i++)
                    {
                        try
                        {
                            Console.WriteLine($"Die {i}. Zahl:");
                            arrayZahlen[i] = int.Parse(Console.ReadLine());
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Die Zahlen müssen ganze Zahlen sein.");
                        }
                    }
                    Array.Sort(arrayZahlen);
                    break;
                }
            case "2":
                {
                    Console.WriteLine("Bitte gib eine Zahl ein: ");
                    try
                    {
                        int Zahl = int.Parse(Console.ReadLine());
                        bool gefunden = false;
                        foreach (int Element in arrayZahlen)
                        {
                            if (Element == Zahl) { gefunden = true; break; }
                        }
                        if (gefunden == true) { Console.WriteLine($"Die Zahl {Zahl} ist im Array vorhanden."); break; }
                        else Console.WriteLine($"Die Zahl {Zahl} ist nicht im Array enthalten.");

                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Die Zahlen müssen ganze Zahlen sein.");
                    }
                    break;
                }
            case "3":
                {
                    Console.WriteLine("Bitte gib 5 Strings ein.");
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine($"Die {i}. Zeichenkette:");
                        arrayZeichen[i] = Console.ReadLine();
                    }
                    for (int i = arrayZeichen.Length-1; i >= 0; i--)
                    {
                        Console.WriteLine(arrayZeichen[i]);
                    }

                    break;
                }
            case "4":
                {
                    b = false; 
                    break;
                }
                
            default:
                {
                    Console.WriteLine("Huch?");
                    break;
                }
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Was Falsches wurde eingegeben.");
    }

}




