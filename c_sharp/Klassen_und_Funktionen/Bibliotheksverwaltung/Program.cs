// Bibliotheksverwaltung
Console.WriteLine("Willkommen zur Bibliothek!");
Thread.Sleep(2000);
int Anzahl = 5;
String[] arrayBuecher = new string[Anzahl];

// a) Bibliothek mit 5 Büchern bestücken
String[] buecher = {
    "Ich, der Roboter - Isaac Asimov", 
    "Der Herr der Ringe - J.R.R. Tolkien", 
    "Der kleine Prinz - Antoine de Saint-Exupéry", 
    "Momo - Michael Ende", 
    "Krieg und Frieden - Lew Tolstoi" };
Console.WriteLine("Du hast eingegeben:");
for (int i = 0; i < arrayBuecher.Length; i++) 
{
    arrayBuecher[i] = buecher[i];
    Console.WriteLine(arrayBuecher[i].ToString());
}

Thread.Sleep(2000);
Console.WriteLine("---------------------------------");
// b) Sortiere alphabetisch und zeige die Bücher auf der Konsole an
Console.WriteLine("Sortiert mit BubbleSortAlphabet:");
String[] array = BubbleSortAlphabet(arrayBuecher);
for (int lauf = 0; lauf < array.Length; lauf++) 
{
    Console.WriteLine($"{lauf}.: {array[lauf]}");
}

Console.WriteLine("Andere Ausgabe mit Array.Sort:");
// Oder alternativer Ausdruck
foreach (var item in array)
{
    Console.WriteLine(item.ToString());
}
Thread.Sleep(2000);
Console.WriteLine("---------------------------------");

// Interaktion: Benutzer gibt Titel ein, nach dem gesucht wird
Console.WriteLine("Bitte gib einen Titelanfang ein. Wir prüfen dann, ob er in der Bibliothek vorhanden ist.");
String eingabe = Console.ReadLine();

try 
{
    bool gefunden = false;
    foreach (var buch in array)
    {
        if (buch.StartsWith(eingabe))
        {
            String autor = buch.Split(" - ")[1];
            Console.WriteLine($"Das Buch wurde geschrieben von {autor}.");
            gefunden = true;
            break;
        }
    }
    if (!gefunden) 
    {
        Console.WriteLine("Ein Buch mit diesem Titel wurde nicht in der Bibliothek gefunden.");
    }
    
} 
catch (FormatException) 
{
    Console.WriteLine("Bitte gib einen vollständigen Titel ein.");
}

// Funktion sortiert Bücher alphabetisch
static String[] BubbleSortAlphabet(String[] arr) 
{
    int l = arr.Length;
    String temp = "";
    for (int a = 0; a < l-1; a++) 
    {
        for (int i = 0; i < l-2; i++) 
        {
            if ( arr[i].CompareTo(arr[i+1]) > 0) 
            {
                temp = arr[i+1];
                arr[i + 1] = arr[i];
                arr[i] = temp;
            }
        }
    }
    return arr;
}