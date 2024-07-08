// See https://aka.ms/new-console-template for more information
Console.WriteLine("Willkommen zum Quiz rund um Zahlen!");
Console.Write("Es werden 5 Fragen gestellt, die du beantworten musst.");
Console.Write("Zum Schluss wird deine erreichte Punktzahl ausgegeben.");

string[] fragen = {
            "Was ist die Hauptstadt von Frankreich? 1) Berlin 2) Paris 3) London",
            "Wie viele Kontinente gibt es? 1) 5 2) 7 3) 6",
            "Welches Element hat das chemische Symbol O? 1) Gold 2) Sauerstoff 3) Silber",
            "In welchem Jahr landete der erste Mensch auf dem Mond? 1) 1969 2) 1972 3) 1958",
            "Wie viele Farben hat ein Regenbogen? 1) 7 2) 6 3) 8"
        };
int[] antworten = { 2, 2, 2, 1, 1 };
int punktzahl = 0;
int antwort;

Console.WriteLine("Willkommen zum Quiz-Spiel!");

int frageIndex = 0;
while (frageIndex < fragen.Length)
{
    Console.WriteLine(fragen[frageIndex]);
    try
    {
        antwort = Convert.ToInt32(Console.ReadLine());
        if (antwort == antworten[frageIndex])
        {
            Console.WriteLine("Richtig!");
            punktzahl++;
        }
        else
        {
            Console.WriteLine("Falsch!");
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Ungültige Eingabe. Bitte gib eine Zahl ein.");
        continue;
    }
    frageIndex++;
}

float endPunktzahl = (float)punktzahl;
Console.WriteLine($"Spiel beendet. Deine Punktzahl: {endPunktzahl}/5.0");

