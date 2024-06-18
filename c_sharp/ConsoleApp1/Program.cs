// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hallo, wer bist du?");
string Name = Console.ReadLine();
Console.WriteLine(Name + ", wie geht es?");
string Antwort = Console.ReadLine();
if (Antwort == "gut")
    Console.WriteLine("Das freut mich!");
if (Antwort == "schlecht")
    Console.WriteLine("Das tut mir leid.");