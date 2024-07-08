// Mitarbeiterverwaltung über Konsolenanwendung
Console.WriteLine("#################################################");
Console.WriteLine("############# Mitarbeiterverwaltung #############");
Console.WriteLine("#################################################");

// Hauptprogramm
// Test
MitarbeiterVerwaltung verwaltung = new MitarbeiterVerwaltung();

Mitarbeiter m1 = new Mitarbeiter(1, "Max Müller", "Chef", 3204.23);
Mitarbeiter m2 = new Mitarbeiter(2, "Irene Müller", "Chefin", 3204.23);;
verwaltung.MitarbeiterHinzufuegen(m1);
verwaltung.MitarbeiterHinzufuegen(m2);
verwaltung.MitarbeiterAnzeigen();
Console.WriteLine("############ Aktualisieren ###########");
verwaltung.MitarbeiterAktualisieren(1, "Max Müller", "Chef", 4500.01);
verwaltung.MitarbeiterAnzeigen();
Console.WriteLine("############### Löschen ###############");
verwaltung.MitarbeiterLoeschen(1);
verwaltung.MitarbeiterAnzeigen();