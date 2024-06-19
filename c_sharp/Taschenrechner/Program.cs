Console.WriteLine("############ Taschenrechner ##############");
Console.WriteLine("");
float Ergebnis = 0;
string Text = "Ergebnis: ";
try 
{
    Console.WriteLine("Bitte geben Sie die erste Zahl ein.");
    float Zahl1 = float.Parse(Console.ReadLine());
    Console.WriteLine("Mit welchem Operator (+, -,*, /) sollen die beiden Zahlen verknüpft werden?");
    string Operator = Console.ReadLine();
    Console.WriteLine("Bitte geben Sie nun die zweite Zahl ein.");
    float Zahl2 = float.Parse(Console.ReadLine());
    if (Operator == "+") Ergebnis = Zahl1 + Zahl2;
    if (Operator == "-") Ergebnis = Zahl1 - Zahl2;
    if (Operator == "*") Ergebnis = Zahl1 * Zahl2;
    if (Operator == "/")
        if (Zahl2 != 0) Ergebnis = Zahl1 / Zahl2;
        else Text = "Division durch null.";
}
catch
{
    Console.WriteLine("Hier stimmt etwas nicht!");
}
if (Text == "Ergebnis: ") Text = Text + Ergebnis;
Console.WriteLine(Text);

