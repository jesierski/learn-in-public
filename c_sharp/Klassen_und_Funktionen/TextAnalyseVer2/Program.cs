// Sehr elegante Version 2 der Textanalyse
var (anzahlWörter, durchschnittlicheWortlänge) = TextAnalyse("Dies ist ein Beispieltext zur Demonstration.");
Console.WriteLine($"Anzahl der Wörter: {anzahlWörter}, Durchschnittliche Wortlänge: {durchschnittlicheWortlänge}");
 
static (int, double) TextAnalyse(string text)
{
    string[] wörter = text.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
    int anzahlWörter = wörter.Length;
    int gesamtLänge = 0;
    foreach (var wort in wörter)
    {
        gesamtLänge += wort.Length;
    }
    double durchschnittlicheWortlänge = (double)gesamtLänge / anzahlWörter;
    return (anzahlWörter, durchschnittlicheWortlänge);
} 

