/* a) Definiere eine Klasse Person mit den Eigenschaften Name und ID. 
 * Mach diese Eigenschaften über Konstruktoren initialisierbar.  */
public class Person
{
    // Attribute der Elternklasse Person
    public string Name { get; set; }
    public int ID { get; set; }

    // Konstruktor der Elternklasse Person
    public Person(string name, int id)
    {
        Name = name;
        ID = id;
    }
}

/* b) Erstelle von Person abgeleitete Klassen Lehrer und Schüler. 
 * Füge der Klasse Lehrer das Feld Fach und der Klasse Schüler ein Dictionary Noten hinzu. 
 * Implementiere in beiden Klassen passende Konstruktoren. */

public class Lehrer : Person
{
    // zusätzliches Attribut der Kindklasse Lehrer
    public string Fach { get; set; }

    // Konstruktor der Klasse Lehrer
    public Lehrer(string name, int id, string fach) : base(name, id)
    {
        Fach = fach;
    }
}

public class Schueler : Person
{
    // zusätzliches Attribut der Kindklasse Noten
    public Dictionary<string, int> Noten { get; set; }

    // Konstruktor der Klasse Schueler
    public Schueler(string name, int id, Dictionary<string, int> noten) : base(name, id)
    {
        Noten = noten;
    }
}

/* c) Definiere eine Klasse Klasse mit den Eigenschaften 
 * Klassenname, Klassenlehrer (vom Typ Lehrer) und SchuelerListe (eine Liste von Schüler). 
 * Implementiere einen Konstruktor, der den Klassenname und den Klassenlehrer initialisiert. 
 * Füge eine Methode SchuelerHinzufuegen hinzu, um Schüler zur Liste hinzuzufügen. */
public class Klasse
{
    // Attribute der Klasse Klasse
    public string Klassenname;// { get; set; }
    public Lehrer Klassenlehrer;
    public List<Schueler> Schuelerliste { get; set; }

    // Konstruktor der Klasse Klasse
    public Klasse(string klassenname, Lehrer klassenlehrer, List<Schueler> schuelerliste)
    {
        Klassenname = klassenname;
        Klassenlehrer = klassenlehrer;
        Schuelerliste = schuelerliste;
    }

    // Methode, um Schüler zur Liste hinzuzufügen
    public void SchuelerHinzufuegen(Schueler schueler)
    {
        Schuelerliste.Add(schueler);
    }
}