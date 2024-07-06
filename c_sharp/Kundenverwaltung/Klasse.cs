using System;

namespace Kundenverwaltung
{
	public class Kunde
	{
		// Attribute der Klasse Kunde
		public string Vorname {  get; set; }
		public string Nachname { get; set; }
		public string Adresse { get; set; }
		public string PLZ_Ort {  get; set; }
		public int Tel {  get; set; }

		// Konstruktor der Klasse Kunde
		public Kunde(string vorname, string nachname, string adresse, string plz_ort, int tel)
	
		{
			this.Vorname = vorname;
			this.Nachname = nachname;
			this.Adresse = adresse;
			this.PLZ_Ort = plz_ort;
			this.Tel = tel;
		}
	}
}
