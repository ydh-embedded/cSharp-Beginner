using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Indexer;

class Program
{
        class Clients
        {
            private string[] names = new string[10];
            public string this[int index]
            {
                get { return names[index];}
                set { names[index] = value;}
            }
        }
    static void Main(string[] args)
    {
        
                    Console.WriteLine(@"

            **************************************************************************

                    Indexer

                    Ein Indexer erlaubt es, Objekte wie ein Array zu indizieren. 

                    Wie bereits früher besprochen, ist eine String-Variable
                    tatsächlich ein Objekt derString Klasse.
                    Darüber hinaus ist die String-Klasse tatsächlich ein
                    Array von Char-Objekten. Auf diese Weise implementiert
                    die String-Klasse einen Indexer,
                    damit wir auf ein beliebiges Zeichen (Char-Objekt) über
                    seinen Index zugreifen können: 

                    Summary:

                    Arrays verwenden Integer-Indizes, aber Indexer
                    können jeden beliebigen Index-Typ verwenden,
                    wie z.B. Strings, Zeichen usw.

            **************************************************************************");


            string str = "Hello World from Line 48";
            char x = str[4];
            Console.WriteLine(x);

                    Console.WriteLine(@"

            **************************************************************************

                    Indexer

                    As you can see, the indexer definition includes
                    the this keyword and an index, which is used to get and
                    set the appropriate value.

                    Now, when we declare an object of class Clients,
                    we use an index to refer to specific objects like the elements of an array: 

                    Summary:

                    AYou typically use an indexer if
                    the class represents a list, collection, or array of objects.

            **************************************************************************");

            Clients c = new Clients();
            c[0] = "Dave";
            c[1] = "Bob";
            
            Console.WriteLine(c[1]);
    }
}
