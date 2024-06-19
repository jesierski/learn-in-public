// See https://aka.ms/new-console-template for more information
using System;
using System.Linq.Expressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main()
    {


        // Konversation mit dem Nutzer
        Console.WriteLine("Hallo, wie ist dein Name?");
        string Name = Console.ReadLine();
        Console.WriteLine("Schön, dass du da bist, " + Name + "!");
        Console.WriteLine("Welches ist deine Lieblingszahl?");
        Console.WriteLine("Deine Lieblingszahl: ");
        int Zahl = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Du hast die Zahl " + Zahl + " eingegeben.");

        // Verzweigung > 100 und <= 100
        if (Zahl > 100)
        {
            Console.WriteLine("Deine Zahl ist größer als 100. Das ist eine ziemlich große Zahl!");
        }
        else
        {
            Console.WriteLine("Deine Zahl ist 100 oder kleiner. Eine bescheidene Wahl!");
        }

        // Gerade oder ungerade Zahl?
        switch (Zahl % 2)
        {
            case 0: Console.WriteLine("Deine Zahl ist gerade. Sehr symmetrisch!"); break;
            case 1: Console.WriteLine("Deine Zahl ist ungerade. Wie interessant!"); break;
            default: Console.WriteLine("Hier stimmt etwas nicht: "); break;

        }
    }
}






