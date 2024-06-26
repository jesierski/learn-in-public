// Erzeuge Monster
public class Monster
{
    public string Name, Wesen;
    public Monster(string N string W)
    {
        Name = N; Wesen = W;
    }
    public void Show() 
    {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Wesen: " + Wesen);
    }
}
