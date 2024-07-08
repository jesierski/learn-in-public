/* a) Definiere eine Klasse Frage, die Eigenschaften für den 
 * Fragetext, die vier Antwortmöglichkeiten und die korrekte Antwort enthält. 
 * Implementiere einen Konstruktor, der alle diese Eigenschaften initialisiert.  */

using System.Runtime.ConstrainedExecution;

public class Frage
{
	// Eigenschaften von Frage
	public string Fragetext;
	public string[] AntwortVorgaben;
	public string RichtigeAntwort;

	// Konstruktor des Objekts vom Typ Frage
	public Frage(string Fragetext, string[] AntwortVorgaben, string RichtigeAntwort)
	{
		this.Fragetext = Fragetext;
		this.AntwortVorgaben = AntwortVorgaben;
		this.RichtigeAntwort = RichtigeAntwort;
	}

    // Methode zum Fragen stellen
    /* b) Implementiere eine Methode StelleFrage(), die 
     * eine Frage und die Antwortmöglichkeiten in der Konsole ausgibt und 
     * die Antwort des Nutzers entgegennimmt.Die Methode soll überprüfen, 
     * ob die Antwort korrekt ist, und entsprechend true oder false zurückgeben.*/

    public bool StelleFrage()
    {
        Nullable<bool> richtig = null;
        bool weiter = true;
        while (weiter)
        {
            Console.WriteLine("Behauptung: " + Fragetext.ToString());
            for (int i = 0; i < AntwortVorgaben.Count(); i++)
            {
                Console.WriteLine((i+1) + ") " + AntwortVorgaben[i]);
            };
            Console.WriteLine("Bitte antworte mit 1, 2, 3, oder 4.");

            try
            {
                string Eingabe = Console.ReadLine();
                if (Eingabe == RichtigeAntwort)
                {
                    Console.WriteLine("Das war richtig!");
                    richtig = true;
                }
                else
                {
                    Console.WriteLine("Das war leider nicht richtig.");
                    richtig = false;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Bitte gib die Ziffern 1, 2, 3 oder 4 ein, um die Antwort auszuwählen.");
                weiter = true;
            }
            weiter = false;
        }
        return (bool)richtig;

    }
}


