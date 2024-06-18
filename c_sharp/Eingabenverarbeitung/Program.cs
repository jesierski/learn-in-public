// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hallo, wie ist dein Name?");
string Name = Console.ReadLine();
Console.WriteLine(Name + ", schön, dass du da bist! ");
Console.WriteLine("Wie geht's dir heute? Bist du \"glücklich\", \"traurig\" oder \"neutral\"?");
string benutzereingabe = Console.ReadLine();
if (benutzereingabe == "glücklich" || benutzereingabe == "Glücklich")
{
    Console.WriteLine("Das ist schön! :-)");
}
else if (benutzereingabe == "traurig" || benutzereingabe== "Traurig") 
{ 
    Console.WriteLine("Das ist schade. :-(");
}
else if (benutzereingabe == "neutral" || benutzereingabe == "Neutral")
{
    Console.WriteLine("Das ist immerhin nicht traurig. :-|");
}
else 
{
    Console.WriteLine("Ich habe dich leider nicht verstanden.");
}
