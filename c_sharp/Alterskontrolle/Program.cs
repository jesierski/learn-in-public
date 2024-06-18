// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main()
    {
        Console.WriteLine("Wie heißt du?");
        string Name = Console.ReadLine();
        Console.WriteLine("Wie alt bist du?");
        string Alter = Console.ReadLine();
        int alt = Int32.Parse(Alter);
        if (alt >= 18)
        {
            Console.WriteLine(Name + ", du darfst fahren.");
            if (alt <= 21)
                Console.WriteLine("Es gibt jedoch einige Einschränkungen, die du beachten musst.");
        }
        else
        {
            Console.WriteLine(Name + ", du bist noch zu jung, um zu fahren.");
            int diff = 18 - alt;
            if (diff == 1)
            {
                Console.WriteLine("Warte noch " + diff.ToString() + " Jahr.");
            }
            else {
                Console.WriteLine("Warte noch " + diff.ToString() + " Jahre.");
            }
        }
    }
}