// Mitarbeiter-Verwaltung
Console.WriteLine("################ Mitarbeiter-Verwaltung ################");

// Füge einige Mitarbeiter hinzu
Mitarbeiter ma1 = new Mitarbeiter("Max Müller", 1,"F&E",5327.30);
ma1.ZeigeDetails();

Manager ma2 = new Manager("Irene Meier", 2, "Management", 12654.22, 120000.0);
ma2.ZeigeDetails();

/*d) In der Main-Methode deines Programms, 
 * erstelle einige Objekte der Klassen Mitarbeiter und Manager und 
 * füge sie einer Liste von Mitarbeitern hinzu. Durchlaufe die Liste mit einer Schleife 
 * und rufe für jedes Objekt die Methode ZeigeDetails() auf. */

Mitarbeiter ma3 = new Mitarbeiter("Reiner Schmidt", 3, "F&E", 4334.37);
Mitarbeiter ma4 = new Mitarbeiter("Alba Gündogan", 4, "F&E", 5410.89);
Mitarbeiter ma5 = new Mitarbeiter("Isa Terlic", 5, "Kunden", 2988.54);
Mitarbeiter ma6 = new Mitarbeiter("Mala Felinski", 6, "Kunden", 3110.67);
Manager ma7 = new Manager("Svenja Rado", 7, "Management", 14854.10, 90000.0);
Manager ma8 = new Manager("Irene Meier", 8, "Management", 9784.90, 175000.0);


List<Mitarbeiter> mitarbeiter = new List<Mitarbeiter>();
mitarbeiter.Add(ma1);
mitarbeiter.Add(ma2);
mitarbeiter.Add(ma3);
mitarbeiter.Add(ma4);
mitarbeiter.Add(ma5);
mitarbeiter.Add(ma6);
mitarbeiter.Add(ma7);
mitarbeiter.Add(ma8);

Console.WriteLine("Zeige Details aller Mitarbeiter und Manager");
foreach (Mitarbeiter ma in mitarbeiter) 
{
    ma.ZeigeDetails();
    Console.WriteLine("---------------------------------------------");
}

/*e) Erkläre, wie das Konzept der Kapselung in deinem Programm umgesetzt wird und 
 * warum es sinnvoll ist, Eigenschaften privat zu setzen und 
 * öffentliche Methoden für den Zugriff darauf zu verwenden.  */

/* Kapselung wird mit einer Elternklasse umgesetzt, von der die Kinderklassen erben.
 * Eigenschaften können private gesetzt werden, wenn für den Zugriff öffentliche
 * Methoden verfügbar sind. Dann muss auf die Eigentschaften nicht direkt zugegriffen werden.
 * Nach dem Prinzip möglichst wenig öffentlich machen.

 */


