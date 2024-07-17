// Kostenberechnung der Cloud-Servíces
public class Provider
{
    string Name;
    double Grundgebuehr;
    double Speicherplatz;
    double Netzwerkverkehr;
    double Arbeitsspeicher;
    double ArbeitsspeicherKostenfrei;
    double Rechenleistung;
    double RechenleistungKostenfrei;

    public Provider(
        string name,
        double grundgebuehr,
        double speicherplatz,
        double netzwerkverkehr,
        double arbeitsspeicher,
        double arbeitsspeicherKostenfrei,
        double rechenleistung,
        double rechenleistungKostenfrei)
    {
        this.Name = name;
        this.Grundgebuehr = grundgebuehr;
        this.Speicherplatz = speicherplatz;
        this.Netzwerkverkehr = netzwerkverkehr;
        this.Arbeitsspeicher = arbeitsspeicher;
        this.ArbeitsspeicherKostenfrei = arbeitsspeicherKostenfrei;
        this.Rechenleistung = rechenleistung;
        this.RechenleistungKostenfrei = rechenleistungKostenfrei;
    }

    public static double Gesamt(Provider provider, int cpu, int arbspeicher, int spplatz, int netzwerk)
    {
        double kosten = 0;
        kosten = provider.Grundgebuehr +
            provider.Speicherplatz * spplatz +
            provider.Netzwerkverkehr * netzwerk +
            provider.Arbeitsspeicher * arbspeicher -
            provider.ArbeitsspeicherKostenfrei * provider.Arbeitsspeicher +
            provider.Rechenleistung * cpu -
            provider.RechenleistungKostenfrei * provider.Rechenleistung;
        return kosten;
    }

    public static void Main(string[] args) 
    {
        List<Provider> liste = new List<Provider>();
        Provider p1 = new Provider ("a)", 0, 0.01, 0.001, 1, 0, 1, 0);        
        liste.Add(p1);
        Provider p2 = new Provider("b)", 5, 0.005, 0.01, 0.5, 1, 0.5, 1);
        liste.Add(p2);
        Provider p3 = new Provider("c)", 20, 0.05, 0, 0.2, 5, 0.2, 2);
        liste.Add(p3);


        Console.WriteLine(" ###################################################################");
        Console.WriteLine(" # Kosten bei verschiedenen Anbietern ##############################");
        Console.WriteLine(" ###################################################################");
        foreach (Provider p in liste) 
        {
            Console.WriteLine($" Provider {p.Name}\r\n " + 
                "Projekt a: " + Gesamt(p, 5, 5, 100, 100) + " USD - "+
                "Projekt b: " + Gesamt(p, 10, 50, 250, 500) + " USD - "+
                "Projekt c: " + Gesamt(p, 7, 50, 20, 1000) + " USD");
        }
        Console.WriteLine(" ###################################################################");
    }

}


