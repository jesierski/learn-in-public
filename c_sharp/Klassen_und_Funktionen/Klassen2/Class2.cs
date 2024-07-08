// Erzeuge Monster
public class Monster
{
    public string Name, Wesen;
    public Monster(string N, string W)
    {
        Name = N; Wesen = W;
    }
    public void Show()
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Wesen: " + Wesen);
        Console.WriteLine("Typ: " + Type());
    }
    public virtual string Type() // class Monster
    {
        return("Monster");
    }
}
public class GMonster : Monster 
{
    public GMonster(string N, string W) : base(N, W) 
    { 
    }
    public override string Type() // class GMonster 
    {
        return("Geistes-Monster");
    }
}
public class SMonster : Monster 
{
    public SMonster(string N, string W) : base(N, W)
    {
    }
    public override string Type() // class SMonster
    {
        return ("Seelen-Monster");
    }
}