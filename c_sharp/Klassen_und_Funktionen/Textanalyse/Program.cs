/* Programm, das eine einfache Textanalyse durchführt. 
 * Deine Aufgabe besteht darin, eine Funktion zu erstellen, 
 * die einen Text als Parameter erhält und die Anzahl der Wörter 
 * sowie die durchschnittliche Wortlänge berechnet. 
 * Die Funktion soll dann beide Werte an die aufrufende Stelle zurückgeben. 
 * Beachte, dass Wörter durch Leerzeichen getrennt sind.  */
Console.WriteLine("################### Textanalyse ####################");

/* a) Definiere zuerst eine Funktion namens TextAnalyse, die einen String 
 * (den zu analysierenden Text) als Parameter annimmt und ein Tupel zurückgibt, 
 * das aus zwei Elementen besteht: der Gesamtzahl der Wörter und der durchschnittlichen Wortlänge im Text. 
 */

static Tuple<int,double> TextAnalyse(string Text) 
{
    Tuple<int, double> analyse = new Tuple<int, double>(CountWords(Text), CountAvg(Text));
    return analyse;
}

/* b) Implementiere in der Funktion die Logik, 
 * um die Anzahl der Wörter zu zählen und die durchschnittliche Wortlänge zu berechnen. */

static int CountWords(string text)
{
    // Teile den Text an Leerzeichen, Satzzeichen und Zeilenwechsel auf und zähle die Wörter
    string[] words = text.Split(new char[] { ' ', '.', ',', '?', '!', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);
    return words.Length;
}

static double CountAvg(string text) 
{
    // Teile den Text in Wörter auf
    string[] words = text.Split(new char[] { ' ', '.', ',', '?', '!', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries);

    // Berechne die Gesamtlänge der Wörter
    int totalWordLength = words.Sum(w => w.Length);

    // Berechne die durchschnittliche Wortlänge (gerundet auf 2 Dezimalstellen)
    double avgWordLength = (double)totalWordLength / words.Length;
    avgWordLength = Math.Round(avgWordLength, 2);

    return avgWordLength;
}

// Hauptprogramm
string text = "Das ist ein Tupel. Und ein paar Wörter mehr.";
Console.WriteLine(text);
Console.WriteLine(TextAnalyse(text));
