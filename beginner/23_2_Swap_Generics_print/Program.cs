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
        
            

        ");


//REVIEW - class Printer
class Printer
{
    public static void Print<T>( T value)       //SECTION - wir erstellen eine statische Methode um diese aufrufen zu können ohne eine Instanz der Printer klasse erstellen zu müssen
    {                                           //SECTION - Die Print Methode kann jeden Typ annehmen  und ist damit nicht auf die Daten der Instanz der Printer Klasse angewiesen
        System.Console.WriteLine(value);
    }
}