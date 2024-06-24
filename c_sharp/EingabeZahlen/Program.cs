// Eingabe von Zahlen und Prüfung einiger Bedingungej
Console.WriteLine("Bitte gib beliebige ganze Zahlen ein. Beende mit Engabe der 0 (Null).");
int n = 1;
int Laufvariable = 0;
// Eingabe der Zahlen
while (n!= 0) 
{
    Console.WriteLine("Bitte eine Zahl eingeben. Beenden mit 0.");
    try 
    {
        n = Convert.ToInt32(Console.ReadLine());
        Laufvariable++;
        
        // Wurde eine gerade oder ungerade Zahl eingegeben?
        if (n%2 == 0) 
        {
            Console.WriteLine($"Die Eingabe {n} ist eine gerade Zahl.");
        }
        else 
        {
            Console.WriteLine($"die Eingabe {n} ist eine ungerade Zahl.");
        }

        // Berechne den Quadratwert der Eingabe
        float x = (float)n;
        float y = (float)Math.Pow(x,2);
        Console.WriteLine("Der Quadratwert der Eingabe ist: " + y);

        // Wurde eine Zahl > 100 und Vielfaches von 10 eingegeben?
        if (n > 100 && (n % 10 == 0))
        {
            Console.WriteLine($"Die Zahl {n} ist größer als 100 und ohne Rest durch 10 teilbar.");
        }
        else if (n == 100) 
        {
            Console.WriteLine($"Die Zahl {n} ist 100 und durch 10 teilbar.");
        }
        else
        {
            Console.WriteLine($"Die Zahl {n} ist kleiner 100 und kein Vielfaches von 10.");
        }
    }
    catch (FormatException) 
    { 
        Console.WriteLine("Die Eingabe war keine ganze Zahl.");
        continue;
    }
}
