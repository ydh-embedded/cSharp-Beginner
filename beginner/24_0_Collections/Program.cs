
using System;
using System.Collections.Generic;

namespace _23_4_Swap_Generics_LIFO_II;

// REVIEW - class Program
class Program
{
    static void Main(string[] args)
    {
                Console.WriteLine(@"

            @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%%###%%%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%##*******##%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            @@@@@@@@@@@@@@@@@@@@@@@@@@@%#***************##%%@@@@@@@@@@@@@@@@@@@@@@@@@@
            @@@@@@@@@@@@@@@@@@@@@@@@@###*******************###%@@@@@@@@@@@@@@@@@@@@@@@
            @@@@@@@@@@@@@@@@@@@@%%#****************************##%%@@@@@@@@@@@@@@@@@@@
            @@@@@@@@@@@@@@@@@%%##**********************************##%%@@@@@@@@@@@@@@@
            @@@@@@@@@@@@@@@###***************************************#*#%@@@@@@@@@@@@@
            @@@@@@@@@@%%##******************+++++++++++******************##%%@@@@@@@@@
            @@@@@@@%##*****************+=-----------------=+*****************###%@@@@@
            @@@@@%##****************=-------------------------=+****************##%@@@
            @@@@##***************+-------------------------------+************####%@@@
            @@@@***************+-----------------------------------+*******#######%@@@
            @@@@**************=------------=+*********+==-----------=***##########%@@@
            @@@@*************-----------+*****************+----------+##%#########%@@@
            @@@@************----------+*********************+----=+*##############%@@@
            @@@@***********----------*************************+*######%+++##*++###%@@@
            @@@@**********+---------**********************#############--=##---###%@@@
            @@@@**********---------+******************####%%#######*===---==---=##%@@@
            @@@@**********---------****************####%###########*==---==---++##%@@@
            @@@@**********---------************####%#################*--+##--=####%@@@
            @@@@**********=--------+*****###########################+--=**---***##%@@@
            @@@@***********---------+########################%######+--*#*--+#####%@@@
            @@@@***********=---------+#######################*-=*#################%@@@
            @@@@************=---------=*###################*=-----=+*#############%@@@
            @@@@***********##+-----------+*##############+=----------+############%@@@
            @@@@*******#######*-------------=++*****++=-------------+#############%@@@
            @@@@****############+---------------------------------+###############%@@@
            @@@@%###%#%###########+=----------------------------+##%#############%%@@@
            @@@@@%%%#################+=---------------------=+*###############%%%%@@@@
            @@@@@@@@@%%%%###############*++=-----------==+*###############%%%%@@@@@@@@
            @@@@@@@@@@@@@%%%###############%%#########################%%%%@@@@@@@@@@@@
            @@@@@@@@@@@@@@@@%%%%###################################%%%%@@@@@@@@@@@@@@@
            @@@@@@@@@@@@@@@@@@@@%%#############################%#%%%@@@@@@@@@@@@@@@@@@
            @@@@@@@@@@@@@@@@@@@@@@%%#%#######################%%%%@@@@@@@@@@@@@@@@@@@@@
            @@@@@@@@@@@@@@@@@@@@@@@@@@%%%%#################%@@@@@@@@@@@@@@@@@@@@@@@@@@
            @@@@@@@@@@@@@@@@@@@@@@@@@@@@@%%%%#########%%%%%@@@@@@@@@@@@@@@@@@@@@@@@@@@
            @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%%%####%%%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@

            

            **************************************************************************
                
                Generic Collections 

                Allgemeine Sammlungen sind die bevorzugte Art zu verwenden,
                solange jedes Element in der Sammlung vom gleichen Datentyp ist.
                Nur gewünschte Datentypen können zu einer allgemeinen
                Sammlung hinzugefügt werden und dies wird durch die Verwendung
                von starker Typisierung erzwungen, was die Möglichkeit von
                Fehlern reduziert.

                Das .NET Framework stellt eine Reihe von allgemeinen Sammlungsklassen
                zur Verfügung, die für die Speicherung und Manipulation
                von Daten nützlich sind.

                Der System.Collections.Generic Namespace enthält
                die folgenden allgemeinen Sammlungen:

                     - List<T>

                     - Dictionary<TKey, TValue>

                     - SortedList<TKey, TValue>

                     - Stack<T>

                     - Queue<T>

                     - Hashset<T>

                Um auf eine allgemeine Sammlung in Ihrem Code zuzugreifen,
                müssen Sie die Anweisung einschließen:
                
                     - using Systems.Collections.Generic;


                Non-Generic Collections 
                
                Nicht-allgemeine Sammlungen können Elemente speichern,
                die vom Typ Object sind. Da ein Object-Datentyp auf einen
                beliebigen Datentyp verweisen kann, laufen Sie Gefahr,
                unerwartete Ergebnisse zu erhalten.
                Nicht-allgemeine Sammlungen können auch langsamer
                im Zugriff und in der Ausführung sein.

                Der System.Collections Namespace enthält die folgenden
                Non-Generic Collections: 

                     - ArrayList

                     - SortedList

                     - Stack

                     - Queue

                     - Hashtable

                     - BitArray 
                
                Tipp:

                Da Non-Generic collections fehleranfällig und
                weniger leistungsfähig sind,
                wird empfohlen, immer Generic Collections aus dem
                
                Namespace: System.Collections.Generic
                
                zu verwenden, wenn verfügbar, und die Verwendung von veralteten
                Sammlungen aus dem System.Collections-Namespace zu vermeiden.



            **************************************************************************");

    }


        //REVIEW - List<T>
        Console.WriteLine("List<T>:");
        List<string> list = new List<string>();
            list.Add("Apple");
            list.Add("Banana");
            list.Add("Cherry");
            Console.WriteLine("List contains:");
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

        //REVIEW - Dictionary<TKey, TValue>
        Console.WriteLine("\nDictionary<TKey, TValue>:");
        Dictionary<string, int> dictionary = new Dictionary<string, int>();
            dictionary.Add("John", 25);
            dictionary.Add("Alice", 30);
            dictionary.Add("Bob", 35);
            Console.WriteLine("Dictionary contains:");
            foreach (KeyValuePair<string, int> pair in dictionary)
            {
                Console.WriteLine("Name: {0}, Age: {1}", pair.Key, pair.Value);
            }

        //REVIEW - SortedList<TKey, TValue>
        Console.WriteLine("\nSortedList<TKey, TValue>:");
        SortedList<string, int> sortedList = new SortedList<string, int>();
            sortedList.Add("John", 25);
            sortedList.Add("Alice", 30);
            sortedList.Add("Bob", 35);
            Console.WriteLine("SortedList contains:");
            foreach (KeyValuePair<string, int> pair in sortedList)
            {
                Console.WriteLine("Name: {0}, Age: {1}", pair.Key, pair.Value);
            }

        //REVIEW - Stack<T>
        Console.WriteLine("\nStack<T>:");
        Stack<string> stack = new Stack<string>();
            stack.Push("Apple");
            stack.Push("Banana");
            stack.Push("Cherry");
            Console.WriteLine("Stack contains:");
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }

        //REVIEW - Queue<T>
        Console.WriteLine("\nQueue<T>:");
        Queue<string> queue = new Queue<string>();
            queue.Enqueue("Apple");
            queue.Enqueue("Banana");
            queue.Enqueue("Cherry");
            Console.WriteLine("Queue contains:");
            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }

        //REVIEW - HashSet<T>
        Console.WriteLine("\nHashSet<T>:");
        HashSet<string> hashSet = new HashSet<string>();
            hashSet.Add("Apple");
            hashSet.Add("Banana");
            hashSet.Add("Cherry");
            hashSet.Add("Apple"); // duplicate item
            Console.WriteLine("HashSet contains:");
            foreach (string item in hashSet)
            {
                Console.WriteLine(item);
            }
    
}