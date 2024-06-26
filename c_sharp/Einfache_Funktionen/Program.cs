// Addition und Multiplikation von Zahlen
Console.WriteLine("######## Addition und Mulitplikation ###########");

/*a) Schreibe eine Funktion BerechneSumme, die zwei Integer-Parameter entgegennimmt 
 * und die Summe dieser beiden Zahlen zurückgibt. */

static int BerechneSumme(int a, int b) 
{ 
    return a + b;
}

/*b) Schreibe eine Funktion Multipliziere, die zwei Integer-Parameter entgegennimmt 
 * und das Produkt dieser beiden Zahlen zurückgibt. */

static int Multipliziere(int a, int b) 
{ 
    return (a * b);
}

/*c) Erstelle eine Schleife in der Main-Methode, die von 1 bis 5 läuft. 
 * Innerhalb der Schleife rufe die Funktion BerechneSumme auf, indem du 
 * der Funktion die Zählervariable und die Zahl 10 übergibst. 
 * Gib das Ergebnis jeder Berechnung auf der Konsole aus. */

int count = 1;
while (count < 6)
{
    int res = BerechneSumme(count, 10);
    Console.WriteLine("Die Summe von count und 10 ist " + res + ".");
    count++;
}

/*d) Nachdem die Schleife abgeschlossen ist, rufe die Funktion Multipliziere auf, 
 * indem du ihr die Zahlen 5 und 10 übergibst. 
 * Gib das Ergebnis auf der Konsole aus.  */
Console.WriteLine("Funktion Multipliziere(5, 10): " + Multipliziere(5, 10));
