using System;

namespace OOP_firstLevel_2022_04_07
{
    class Program
    {

        //ein Objekt einer Instanz der Klasse erzeugen
        static Konto konto = null;
        static void Main(string[] args)
        {
            Console.Title = "Kontoverwaltung";

        }
        static void KontoAnlegen()
        {
            konto = new Konto(); //konto erzeugen und mit Daten füllen
        }
        // Methode für Menü anzeigen
        static void MenuAnzeige ()
        {
            Console.Clear(); // löscht Bildschirmanzeige
            Console.WriteLine("Bitte Aktion auswählen");
            Console.WriteLine("1. Kontodaten anzeigen");
            Console.WriteLine("2. Geld einzahlen");
            Console.WriteLine("4. Prgramm beenden");
            Console.WriteLine();
            //Aufforderung zur Eingabe
            Console.WriteLine("Bitte passende Zahl eingeben: ");
        }
    }
}
