namespace _23_0_Swap_Generics;

class Program
{
//REVIEW - class Program
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
                
            

    //REVIEW - class Utilities
    static class Utilities
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }




            int a = 4, b = 9;
            Swap<int>(ref a, ref b);
            Console.WriteLine(a+" "+b);
            
            string x = "Hello";
            string y = "World";


            Swap<string>(ref x, ref y);
            Console.WriteLine(x+" "+y);
    
    }
}

//REVIEW - Swap
class Swap<T>
{
    static void Swap<T>(ref T a, ref T b)
    {
                T temp = a;
                a = b;
                b = temp;
    }
}