namespace _24_0_Stack_LIFO;

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
                
                Stack<T> & Queue

                Ein Stack ist eine Letzt rein, Zuerst raus (LIFO) Sammlung von Elementen,
                wobei das letzte Element, das in den Stack geht,
                das erste Element ist, das herauskommt.

                Das Einfügen eines Elements in einen Stack wird als Pushing bezeichnet.
                Das Löschen eines Elements aus einem Stack wird als Popping bezeichnet.
                Pushing und Popping können nur an der Oberseite
                des Stacks durchgeführt werden.

                Stacks können verwendet werden, um Undo-Redo-Funktionen zu erstellen,
                Ausdrücke zu parsen (Infix zu Postfix/Präfix-Konversion) und vieles mehr.

                Die C# generische Sammlung Stack<T> Klasse erfordert,
                dass alle Elemente vom selben Typ T sind.

                Stack<T>Eigenschaften beinhalten:

                    Count - Gibt die Anzahl der Elemente im Stapel zurück.
                    Methoden von Stack<T> beinhalten:
                    Peek() - Gibt das Element am oberen Ende des Stapels zurück,
                            ohne es zu entfernen.

                    Pop() - Gibt das Element am oberen Ende des Stapels zurück
                            und entfernt es vom Stapel.

                    Push(T t) - Fügt ein Element t am oberen Ende des Stapels ein.
                            Versuchen wir es jetzt mit Stack<T>:


                Eine Queue ist eine First In, First Out (FIFO) Sammlung von Elementen,
                bei der das erste Element, das in eine Queue eingefügt wird,
                auch das erste Element ist, das herauskommt.

                Das Einfügen eines Elements in eine Queue wird als Enqueue bezeichnet.
                Das Löschen eines Elements aus einer Queue wird als Dequeue bezeichnet.

                Warteschlangen werden immer dann verwendet,
                wenn wir Objekte in der Reihenfolge verwalten müssen,
                beginnend mit dem ersten eingegangenen.

                Szenarien beinhalten das Drucken von Dokumenten auf einem Drucker,
                Call Center Systeme die wartende Personen beantworten, und so weiter.

                Die C# generische Sammlung Queue<T> Klasse verlangt,
                dass alle Elemente vom gleichen Typ T sind.

                Die Eigenschaften von Queue<T> beinhalten:

                    Count - Ruft die Anzahl der Elemente in der Warteschlange ab.
                            Und die Methoden beinhalten:

                    Dequeue() - Gibt das Objekt am Anfang der Warteschlange zurück
                                und entfernt es auch.

                    Enqueue(T t) - Fügt das Objekt t am Ende der Warteschlange hinzu.
                

            **************************************************************************");

       // SECTION Stack
        Stack<int> s = new Stack<int>();
        s.Push(59);
        s.Push(72);
        s.Push(65);

        // Print Stack
        Console.WriteLine("=== Stack ===");
        PrintStack(s);

        Console.WriteLine("\nTop: " + s.Peek());  // 65
        Console.WriteLine("Pop: " + s.Pop());  // 65

        // Print Stack after Pop
        Console.WriteLine("\n=== Stack After Pop ===");
        PrintStack(s);

    }



    static void PrintStack(Stack<int> stack)
    {
        Console.WriteLine("Elements\tCount");
        Console.WriteLine("----------------------");
        foreach (int item in stack)
        {
            Console.WriteLine($"{item}\t\t{stack.Count}");
        }
        Console.WriteLine("----------------------");
        Console.WriteLine("Total Count: " + stack.Count);
    }



    
}
