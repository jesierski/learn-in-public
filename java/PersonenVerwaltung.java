import java.util.List;
import java.util.ArrayList;
import java.io.BufferedWriter;
import java.io.FileWriter;
import java.io.IOException;
import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;

public class PersonenVerwaltung {

    // Klasse Person mit Attributen name und alter
    public class Person {
        String name;
        int alter;

        // Konstruktor der Klasse Person
        public Person(String name, int alter){
            this.name = name;
            this.alter = alter;
        }

        // Methode toString(), die Personendaten als String zurückgibt
        public String toString() {
            return name + ", Alter " + alter;
        }
    }

    // Deklaration Array von Person-Objekten. Dynamisches Array umgesetzt als ArrayList.
    private List<Person> array;
    // Konstruktor für Klasse PersonenVerwaltung
    public PersonenVerwaltung(){
        array = new ArrayList<Person>();
    }

    // Methode Hinzufügen von  Personen im Array vom Typ PersonenVerwaltung
    public void hinzufuegen(String name, int alter){
        array.add(new Person(name, alter));
    }

    // Methode Löschen von Personen anhand des Namens in Kombination mit dem Alter
    public boolean loeschen(String name, int alter){
        boolean removePerson = true;
        for (int i = 0; i < array.size(); i++){
            if (array.get(i).name.equals(name)){
                if (array.get(i).alter == alter){
                    array.remove(array.get(i));
                    System.out.println("Die Person wurde aus der Liste gelöscht.");
                }
                else {
                    removePerson = false;
                    System.out.println("Die Person wurde nicht gefunden.");
                }
            }
        }
        return removePerson;
    }

    // Methode Anzeigen von Personen im Array vom Typ PersonenVerwaltung
    public void anzeigen(){
        System.out.println("Anzeige");
        for (Person person : array){
            System.out.println(person.toString());
        }
    }

    // Methode zum Speichern des Arrays vom Typ PersonenVerwaltung in einer Textdatei personen.txt
    public void speicherePersonen() throws IOException {
        FileWriter fileWriter = new FileWriter("personen.txt");
        BufferedWriter buffer = new BufferedWriter(fileWriter);

        try {

            buffer.flush();
            for (Person person : array){            
                //buffer.append(person.toString());
                buffer.write(person.toString());
                buffer.newLine();
            }
                       
        } catch (IOException e) {
            e.printStackTrace();
        } finally {
            buffer.close();
        }
    }

    // Methode liest Personen aus der Datei personen.txt und lädt sie in das Array vom Typ PersonenVerwaltung.
    public void ladePersonen() throws FileNotFoundException {
        File file = new File("personen.txt");
        Scanner scanner = new Scanner(file);
        try {        
            array.clear();
            System.out.println("Laden");
            while (scanner.hasNextLine()){
                String row = scanner.nextLine();
                System.out.println(row);
                if (!(row.split(", Alter ")[0] instanceof String)) {
                    throw new Error("Fehlermeldung: Die Zeile " + row + " enthält als ersten Teil keinen String.");
                }
                String str = String.valueOf(row.split(", Alter ")[1]);
                if (!(row.split(", Alter ")[1].equals(str))) {
                    throw new Error("Fehlermeldung: Die Zeilte " + row + " enthält als zweiten Teil kein Integer. Die Datei kann nicht geladen werden.");
                }

                String personenName = row.split(", Alter ")[0];
                int personenAlter = Integer.parseInt(row.split(", Alter ")[1]);
                Person person = new Person(personenName, personenAlter);
                array.add(person);
            }
        } 
        catch (Exception e) {
            e.printStackTrace();
            e.getMessage();
        } 
        finally {
            scanner.close();
        }
    }


    public static void main(String[] args) {

        PersonenVerwaltung arrayPersonenVerwaltung = new PersonenVerwaltung();

        /* Einfache Benutzeroberfläche, die es ermöglicht, Personen hinzuzufügen, zu löschen, anzuzeigen und die Speicher- und Ladeoperationen auszuführen.*/
        System.out.println("PersonenVerwaltung");
        System.out.println("Geben Sie den entsprechenden Buchstaben ein.");
        System.out.println("Personen hinzufügen (1), löschen (2), anzeigen (3), Personenliste speichern (4), Personenliste laden (5), Ende (6)");
        // Auf Eingabe lauschen
        Scanner scanner = new Scanner(System.in);
        boolean erneuteEingabe = true;
        while (erneuteEingabe){
            try {
                switch(scanner.next()){
                    case "1":
                        System.out.println ("Name eingeben: ");
                        String personenName = scanner.next();
                        System.out.println("Alter eingeben: ");
                        int personenAlter = Integer.valueOf(scanner.next());
                        arrayPersonenVerwaltung.hinzufuegen(personenName, personenAlter);
                        break;

                    case "2":
                        System.out.println ("Name eingeben: ");
                        String personLoeschenName = scanner.next();
                        System.out.println("Alter eingeben: ");
                        int personLoeschenAlter = Integer.valueOf(scanner.next());
                        arrayPersonenVerwaltung.loeschen(personLoeschenName, personLoeschenAlter);
                        break;
                        
                    case "3":
                        arrayPersonenVerwaltung.anzeigen();
                        break;

                    case "4":
                        arrayPersonenVerwaltung.speicherePersonen();
                        break;

                    case "5":
                        arrayPersonenVerwaltung.ladePersonen();
                        break;
                        
                    case "6":
                        erneuteEingabe = false;
                        break;
                    default:
                        System.out.println("Eingabe nicht gültig. Bitte erneut versuchen.");
                }
                System.out.println("Bitte geben Sie die Aktion ein.");

            } catch (Exception e) {
                System.out.println("Ein Fehler ist aufgetreten.");
            }

        }


    }

}
