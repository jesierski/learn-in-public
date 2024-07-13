// Klasse Person, serialisiere Person-Objekte in Datei, Thread deserialisiert und gibt aus 
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Text;
using System;
using System.Collections.Generic;


namespace Serialise_Threads;

public class Program
{
    // Serialisierung
    static void Serialisiere(List<Person> liste) 
    {
        Stream stream = File.Open("D:/git/learn-in-public/c_sharp/Serialise_Threads/Images/personen.dat", FileMode.Create);
        

        
        //BinaryWriter writer = new BinaryWriter(stream);
        //foreach (Person p in liste) 
        //{
        //    writer.Write(p.Name);
        //    writer.Write(",");
        //    writer.Write(p.Alter);
        //    writer.Write(";");
        //}
        //stream.Close();
    }

    //// Deserialisierung
    //static void Deserialisiere()
    //{
    //    string name;
    //    int alter;
    //    Stream stream = File.Open("D:\\git\\learn-in-public\\c_sharp\\Serialise_Threads\\Images\\personen.dat", FileMode.Open);
    //    BinaryReader reader = new BinaryReader(stream);

    //    string all = reader.ReadString();
    //    Console.WriteLine(all);
    //    Console.WriteLine("-----------------------------------------");

    //    int count = all.Count(f => f == ';');
    //    Console.WriteLine(count);
    //    Console.WriteLine("++++++++++++++++++++++++++++++++++++++++");

    //    string[] line = all.Split(';');
    //    Person[] pers = new Person[line.Length];
    //    for (int j = 0; j < line.Length; j++)
    //    {
    //        pers[j] = new Person("a", 1);
    //    }

    //    for (int i = 0; i < line.Length;i++) 
    //    {
    //        string[] person = line[i].Split(",", 2);

    //        pers[i].Name = person[0];
    //        Console.WriteLine("-------------------------------");
    //        Console.WriteLine(person[0]);
    //        pers[i].Alter = Int32.Parse(person[1]);
    //        Person.ZeigeDaten(pers[i]);
    //    }
    //    stream.Close();
    //}

    public static void Main(string[] args) 
    {
        List<Person> personen = new List<Person>();
        Person p0 = new Person("Max", 23);
        personen.Add(p0);
        Person p1 = new Person("Irene", 17);
        personen.Add(p1);
        Person p2 = new Person("Ise", 18);
        personen.Add(p2);

        string[] log = new string[3];

        foreach (Person per in personen) 
        {
            Person.ZeigeDaten(per);
        }

        //Serialisiere(personen);
        Stream stream = File.Open("D:/git/learn-in-public/c_sharp/Serialise_Threads/Images/personen.dat", FileMode.Create);


        foreach (Person p in personen)
        {
            ConsoleApplication.WriteDefaultValues(p, stream, log);
        }
        stream.Close();

        Stream stream2 = File.Open("D:/git/learn-in-public/c_sharp/Serialise_Threads/Images/personen.dat", FileMode.Open);
        //Deserialisiere();

        for (int l = 0; l < 3; l++)
        {
            ConsoleApplication.DisplayValues(stream2);
        }
        stream2.Close();
    }
}
