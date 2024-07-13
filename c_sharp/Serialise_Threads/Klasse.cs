// Klasse Person, serialisiere Person-Objekte in Datei, Thread deserialisiert und gibt aus 
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialise_Threads;

class Person
{
    public string Name { get; set; }
    public int Alter { get; set; }

    public Person(string name, int alter)
    {
        Name = name;
        Alter = alter;
    }

    public static void ZeigeDaten(Person p)
    {
        Console.WriteLine("Name: " + p.Name + " - Alter: " + p.Alter);
    }
}