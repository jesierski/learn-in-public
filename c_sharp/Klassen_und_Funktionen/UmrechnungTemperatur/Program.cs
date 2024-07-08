bool programmLaeuft = true;
while (programmLaeuft)
{
    Console.WriteLine("Wähle die Umrechnung: \n1. Celsius in Fahrenheit\n2. Fahrenheit in Celsius\n3. Programm beenden");
    string auswahl = Console.ReadLine();
    try
    {
        int option = int.Parse(auswahl);
        if (option == 1)
        {
            Console.WriteLine("Gib die Temperatur in Celsius ein:");
            float celsius = float.Parse(Console.ReadLine());
            float fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"{celsius} Grad Celsius entsprechen {fahrenheit} Grad Fahrenheit.");
        }
        else if (option == 2)
        {
            Console.WriteLine("Gib die Temperatur in Fahrenheit ein:");
            float fahrenheit = float.Parse(Console.ReadLine());
            float celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine($"{fahrenheit} Grad Fahrenheit entsprechen {celsius} Grad Celsius.");
        }
        else if (option == 3)
        {
            programmLaeuft = false;
            Console.WriteLine("Programm wird beendet.");
        }
        else
        {
            Console.WriteLine("Ungültige Eingabe. Bitte wähle 1, 2 oder 3.");
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Ungültige Eingabe. Bitte gib eine Zahl ein.");
    }
}