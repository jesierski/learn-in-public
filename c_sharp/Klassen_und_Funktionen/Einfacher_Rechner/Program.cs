// See https://aka.ms/new-console-template for more
// Konversation mit dem Nutzer
Console.WriteLine("Hallo, wie ist dein Name?");
string Name = Console.ReadLine();
Console.WriteLine(Name + ", schön, dass du da bist! ");
Console.WriteLine("Bitte gib zwei ganze Zahlen ein.");
Console.WriteLine("Die erste: ");
float Zahl1 = float.Parse(Console.ReadLine());
Console.WriteLine("Die zweite:");
float Zahl2 = float.Parse(Console.ReadLine());
// Auswahl der Rechenoperation
Console.WriteLine("Welche mathematische Operation soll mit den beiden Zahlen erfolgen?");
Console.WriteLine("Addition (+), Subtraktion (-), Multiplikation (*) oder Division (/)?");
string operation = Console.ReadLine();
float Ergebnis = 0;
string Text = "Ergebnis: ";
try
{
    if (operation == "+") Ergebnis = Zahl1 + Zahl2;
    if (operation == "-") Ergebnis = Zahl1 - Zahl2;
    if (operation == "*") Ergebnis = Zahl1 * Zahl2;
    if (operation == "/") Ergebnis = Zahl1 / Zahl2;
    //if (operation == "/")
    //    if (Zahl2 != 0) Ergebnis = Zahl1 / Zahl2;
    //    else Text = "Division durch null";
}
catch (Exception e)
{
    Text = "Da ist was faul im Staate Dänemark!";
    Console.WriteLine(e.Message);
}
if (Text == "Ergebnis: ") Text = Text + Ergebnis;
Console.WriteLine(Text);
Console.WriteLine("Ist das Ergebnis 'gut' oder 'schlecht'?");
string antwort = Console.ReadLine();
if (antwort == "gut") Console.WriteLine("Na, wunderbar!");
else Console.WriteLine("Ach, wie schade.");

