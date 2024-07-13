using System;
using System.IO;
using System.Text;

namespace Serialise_Threads;

class ConsoleApplication
{
    const string fileName = "D:/git/learn-in-public/c_sharp/Serialise_Threads/Images/personen.dat";

    //static void Main()
    //{
    //    WriteDefaultValues();
    //    DisplayValues();
    //}

    public static void WriteDefaultValues(Person p, Stream stream, string[] log)
    {
      //  using (var stream = File.Open(fileName, FileMode.Append))
      //  {
        using (var writer = new BinaryWriter(stream, Encoding.UTF8, true))
        {
 
            writer.Write(p.Name);
            writer.Write(",");
            writer.Write(p.Alter);
            writer.Write(";");

            log.Append(p.Name);

            //writer.Write(1.250F);
            //writer.Write(@"D:/git/learn-in-public/c_sharp/Serialise_Threads/Images/personen_out.dat");
            //writer.Write(10);
            //writer.Write(true);
        }
    //    }
    }

    public static void DisplayValues(Stream stream2)
    {
        string Name;
        int Alter;

        if (File.Exists(fileName))
        {
            //using (var stream = File.Open(fileName, FileMode.Open))
            //{
            using (var reader = new BinaryReader(stream2, Encoding.UTF8, true))
            {
                Name = reader.ReadString();
                Alter = reader.ReadInt32();
            }
            //}

            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Alter: " + Alter);
        }
    }
}
