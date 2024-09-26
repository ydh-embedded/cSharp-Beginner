namespace _23_1_Swap_Generics;

//REVIEW - class Program
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(@"

            **************************************************************************

                Generics 

                Generics ermöglichen die Wiederverwendung von Code über verschiedene Typen hinweg.

                Als Beispiel deklarieren wir eine Methode, die die Werte ihrer beiden Parameter austauscht: 

                static void Swap(ref int a, ref int b)
                {
                  int temp = a;
                    a = b;
                    b = temp;
                }

                Unsere Swap-Methode funktioniert nur für Integer-Parameter.
                Wenn wir sie für andere Typen verwenden möchten,
                zum Beispiel für Doubles oder Strings,
                müssen wir sie für alle Typen überladen,
                mit denen wir sie verwenden möchten.
                Neben vielen Code-Wiederholungen wird es schwieriger,
                den Code zu verwalten,
                da Änderungen in einer Methode Änderungen
                in allen überladenen Methoden bedeuten.

                Generics bieten einen flexiblen Mechanismus
                zur Definition eines generischen Typs.

                static void Swap<T>(ref T a, ref T b)
                {
                    T temp = a;
                         a = b;
                         b = temp;
                }

                In dem oben genannten Code ist T der Name
                unseres generischen Typs. Wir können ihn nennen,
                wie wir wollen, aber T ist ein häufig verwendeter Name.
                Unsere Swap-Methode nimmt jetzt zwei Parameter vom Typ T.
                Wir verwenden auch den Typ T für unsere temp Variable,
                die zum Austauschen der Werte verwendet wird.

                Info:

                Beachten Sie die Klammern in der Syntax <T>,
                die verwendet werden, um einen generischen Typ zu definieren.

                Wir haben eine generische Swap-Methode implementiert,
                die Werte eines beliebigen Typs T austauschen kann.
                Dies ist ein großartiges Beispiel
                für die Verwendung generischer Methoden in C#.

            **************************************************************************");

        Console.WriteLine(@"

            **************************************************************************
        
        Übersicht

        Dieser Code demonstriert eine generische Swap-Funktion in C#.
        Die Klasse Utilities enthält eine statische Methode Swap,
        die die Werte von zwei Variablen desselben Typs vertauscht.
        Der Code verwendet diese Methode,
        um die Werte von zwei int-Variablen und zwei String-Variablen zu vertauschen.

        
        Hauptmethode

        Die Hauptmethode initialisiert zwei int-Variablen
        
             a und b

        mit den Werten

             4 bzw. 9.
        
        Dann ruft die Swap-Methode diese der Klasse Utilities auf und
        übergibt a und b als Referenz mit dem Schlüsselwort ref.
        Nach dem Tausch gibt sie die Werte von a und b auf der Konsole aus.

        Der gleiche Vorgang wird für zwei String-Variablen 
            
            x und y
        
        mit den Werten „Hello“ bzw. „World“ wiederholt.

        
        Utilities-Klasse und Swap-Methode

        Die Klasse Utilities ist eine statische Klasse,
        die eine einzige statische Methode Swap enthält.
        Diese Methode ist generisch, das heißt,
        sie kann mit jedem Typ T arbeiten.

        Die Swap-Methode nimmt zwei Parameter
        
             a und b [vom Typ T]
             
        mit Hilfe des Schlüsselworts 
        
                ref
        
        auf. Anschließend werden die Werte von a und b
        mit Hilfe einer temporären Variablen temp vertauscht.


        Hier eine schrittweise Erklärung des Swap-Prozesses:

        T temp = a;   - Erstellen Sie eine temporäre Variable temp und
                        weisen Sie ihr den Wert von a zu.

        a = b;        - Weisen Sie a den Wert von b zu.
        b = temp;     - Weisen Sie b den Wert von temp zu
                        (das ist der ursprüngliche Wert von a).

        Auf diese Weise werden die Werte von a und b effektiv vertauscht.     

            **************************************************************************
            ");

        int a = 4, b = 9;
            Utilities.Swap<int>(ref a, ref b);
            Console.WriteLine(a+" "+b);
            
        string x = "Hello";
        string y = "World";
            Utilities.Swap<string>(ref x, ref y);
            Console.WriteLine(x+" "+y);    

         
    }
}
//REVIEW - class Utilities
        static class Utilities
        {
            //REVIEW - Swap
            public static void Swap<T>(ref T a, ref T b)
            {
                T temp =    a;
                a      =    b;
                b      = temp;
            }
        }