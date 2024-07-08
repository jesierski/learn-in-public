// Zensur
Console.WriteLine("Gib eine Note von 1 bis 6 ein: ");
string Note = Console.ReadLine();
int Wert = int.Parse(Note);
if (Wert == 1) Note = "Sehr gut";
if (Wert == 2) Note = "Gut";
if (Wert == 3) Note = "Befriedigend";
if (Wert == 4) Note = "Ausreichend";
if (Wert == 5) Note = "Mangelhaft";
if (Wert == 6) Note = "Ungenügend";
Console.WriteLine(Note);

Console.WriteLine("Oder über switch-case: ");
string Note2 = Console.ReadLine();
int Wert2 = int.Parse(Note2);
switch (Wert2)
{ 
    case 1: Note2 = "Sehr gut"; break;
    case 2: Note2 = "Gut"; break;
    case 3: Note2 = "Befriedigend"; break;
    case 4: Note2 = "Ausreichend"; break;
    case 5: Note2 = "Mangehaft"; break;
    case 6: Note2 = "Ungenügend"; break;
    default: Note2 = "Quatsch!"; break;
}
Console.WriteLine(Note2);