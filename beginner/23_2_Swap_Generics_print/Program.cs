using System;
using System.Collections.Generic;

namespace _23_2_Swap_Generics_print;

//REVIEW - class Program
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(@"
        
        Generische Methoden 

        Wir schreiben ein Programm,
        das den Wert einer Variable beliebigen Typs ausgeben kann.
        Es nimmt einen String, einen Integer und einen Double-Wert
        als Eingabe und sollte sie dann ausgeben.

        Erstellen Sie eine generische Methode Print
        für eine Printer-Klasse, um die gegebenen Aufrufe korrekt auszuführen.

        Beispieleingabe

            Hello
            14
            7.6

        Beispielausgabe

            Zeigt Hello
            Zeigt 14
            Zeigt 7.6
        
        Info:
        Beachten Sie, dass es kein Objekt der Printer-Klasse gibt,
        daher sollte die generische Methode statisch sein.

        ");

            //SECTION - Variables declaration         
            string    text = Console.ReadLine();
            int     intNum = Convert.ToInt32(Console.ReadLine());
            double doubNum = Convert.ToDouble(Console.ReadLine());

            //SECTION - Printer
            Printer.Print(text);
            Printer.Print(intNum);
            Printer.Print(doubNum);
    



    }
}

        System.Console.WriteLine(@"
        
        - wir erstellen eine statische Print Methode um diese aufrufen zu können ohne eine Instanz der Printer klasse erstellen zu müssen
        - Die Print Methode kann jeden Typ annehmen  und ist damit nicht auf die Daten der Instanz der Printer Klasse angewiesen
        - In diesem Fall erscheint es sinnvoll, die Methode Print statisch zu machen, da es sich um eine Dienstprogramm-Methode handelt,
           die zum Drucken beliebiger Datentypen verwendet werden kann.

        ");


//REVIEW - class Printer
class Printer
{
    public static void Print<T>( T value)       
    {                                           
        System.Console.WriteLine(value);
    }
}