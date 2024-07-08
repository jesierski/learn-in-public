// Arraygröße entgegennehmen und Array sortieren
//using System.Buffers.Binary;
//using System.ComponentModel.Design;
//using System.Linq.Expressions;

Console.WriteLine("Hallo, ich verwalte ein Array. Wie groß soll das Array sein?");
try 
{
    int n = Convert.ToInt32(Console.ReadLine());
    if (n > 0)
    {
        int[] Liste = new int[n];

        // Generiere Array zufälliger Ganzzahlen mit der gewünschten Länge
        Random random = new Random();
        for (int i = 0; i < Liste.Length; i++)
        {
            Liste[i] = random.Next(1, 100);
            // Zahlen in Konsole ausgeben
            if (i == 0)
            {
                Console.Write(Liste[i]);
            }
            else
            {
                Console.Write(", " + Liste[i]);
            }
        }
        Console.WriteLine(" ");

        // Sortiere Array
        // mit Array.Sort
        int[] ListeSort = Liste;
        Array.Sort(ListeSort);
        Console.WriteLine("ArraySort: [{0}]", string.Join(", ", ListeSort));
        // mit Bubble Sortierung
        int[] ListeSort2 = BubbleSortierung(Liste);
        Console.WriteLine("BubbleSort: [{0}]", string.Join(", ", ListeSort2));

        // Suche erste Zahl > 50, gib sie aus mit ihren Index im Array.
        int Laufvariable = 0;
        while ((Laufvariable < ListeSort.Length) && (ListeSort[Laufvariable] <= 50))
        {
            Laufvariable++;
        }
        if (Laufvariable < ListeSort.Length)
        { 
            Console.Write($"Erste Zahl größer als 50: {ListeSort[Laufvariable]} an der Stelle {Laufvariable}. ");
        }
    else
        Console.Write("Keine Zahl größer als 50. ");
    } 
    else 
    {
        Console.WriteLine("Nichts zu sortieren. Die Liste ist leer.");
    }
}
catch (FormatException) 
{
    Console.WriteLine("Die Eingabe konnt nicht verarbeitet werden. Es war keine ganze positive Zahl.");
}

static int[] BubbleSortierung(int[] ListeSort) 
{
    // mit Bubble Sort
    int temp = 0;
    for (int aussen = 0; aussen <= ListeSort.Length - 2; aussen++) // äußere Schleife für Durchlaufen
    {
        for (int innen = 0; innen <= ListeSort.Length - 2; innen++) // innerer Schleife für Vergleich und Swap
        {
            if (ListeSort[innen] > ListeSort[innen + 1])
            {
                temp = ListeSort[innen + 1];
                ListeSort[innen + 1] = ListeSort[innen];
                ListeSort[innen] = temp;
            }
        }
    }
    return ListeSort;

}
