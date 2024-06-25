using System;

public class Class1
{
	public Class1()
	{
        // Quiz mit 5 Fragen, jede hat 4 Antworten, nur 1 richtige
        Console.WriteLine("Hallo Quiz-Sieler!");
        Console.Write("Hier kommen bis zu 5 Fragen, jede mit 4 Antworten. ");
        Console.WriteLine("Doch nur 1 ist die richtige. Weißt du welche?");
        Console.WriteLine("------------------------------------------------");

        String[] arrFragen = {
        "Wie heißt die Hauptstadt von Belgien? A) Amsterdam B) Paris C) Brüssel D) Luxembourg",
        "Welches ist der höchste Berg? A) Zugspitze B) Mount Everst C) Kilimandscharo D) Nanga Parbat",
        "Wie tief ist die tieste Stelle der Erde ab Meeresspiegel? A) 11.020 m B) 9.220 m C) 8.870 m D) 4.500 m",
        "Wie viele Farben hat der Regenbogen? A) 3 B) 8 C) 7 D) 6",
        "Wie groß ist der größte Vogel der Welt? A) europäische Gans B) afrikanische Strauß C) Albatros D) Andenkondor"};
        char[] arrAntworten = { 'C', 'B', 'A', 'C', 'B' };
    }
}
