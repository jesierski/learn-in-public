using System;
using System.Drawing.Graphics;

public class GrafischesObjekt
{
	public GrafischesObjekt()
	{
		string Name = "Grafisches Objekt";
	}

	public GrafischesObjekt erzeuge() 
	{ 
		GrafischesObjekt grafischesObjekt = new GrafischesObjekt();
		return grafischesObjekt;
	}
}

// Rechteck erbt von der Oberklasse GrafischesObjekt den Namen "Grafisches Objekt"
public class Rechteck : GrafischesObjekt 
{
	public Rechteck() 
	{
		string Genauer = "Ich bin ein Rechteck";
	}

}
