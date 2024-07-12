// ##########################################
// ################ Monster #################
// ##########################################
namespace Monsteraktivitaeten;

class Program
{

    enum MonsterStatus 
    {
        Aktiv,
        Inaktiv,
        Unbekannt
    }

    struct Monster 
    { 
        public string Name { get; set; }
        public int Alter {  get; set; }
        public MonsterStatus Status { get; set; }

        public Monster(string name, int alter, MonsterStatus status) 
        { 
            Name = name;
            Alter = alter;
            Status = status;
        }

        public void ZeigeDetails() => Console.WriteLine(
            "Name: " + Name +
            "- Alter: " + Alter +
            "- Status: " + Status); 
    }

    static void Main(string[] args)
    {
        Monster grobi = new Monster("Grobi", 45, MonsterStatus.Aktiv);
        Monster tier = new Monster("Tier", 51, MonsterStatus.Unbekannt);
        Monster samson = new Monster("Samson", 65, MonsterStatus.Inaktiv);
        Monster tiffany = new Monster("Tiffany", 49, MonsterStatus.Inaktiv);
        Monster piggy = new Monster("Miss Piggy", 67, MonsterStatus.Unbekannt);
        Monster gonzo = new Monster("Gonzo", 43, MonsterStatus.Aktiv);
        Monster mimimi = new Monster("Mimimi", 48, MonsterStatus.Aktiv);

        List<Monster> list = new List<Monster>() { grobi, tier, samson, tiffany, piggy, gonzo, mimimi};
        foreach (var mon in list)
        {
            Console.WriteLine(
                "Monstername: " + mon.Name + " - " +
                "Alter: " + mon.Alter + " - " +
                "Status: " + mon.Status
                );
        }
        Console.WriteLine("Das waren alle!");
        Thread.Sleep(1000);

        var aktiveMonster = list.Where(m => m.Status == MonsterStatus.Aktiv);

        string filepath = @"D:\temp\c_sharp_LINQ\aktive_monster.txt";
        using (StreamWriter writer = new StreamWriter(filepath)) 
        {
            foreach (var monster in aktiveMonster) 
            { 
                writer.WriteLine(
                    "Monstername: " + monster.Name + " - " +
                    "Alter: " + monster.Alter + " - " +
                    "Status: " + monster.Status
                    );
            }
        }

        using (StreamReader reader = new StreamReader(filepath))
        {
            string inhalt = reader.ReadToEnd();
            Console.WriteLine("Monster in Datei 'aktive_monster.txt': ");
            Console.WriteLine(inhalt);
            Thread.Sleep(3000);
        }
    }
}

