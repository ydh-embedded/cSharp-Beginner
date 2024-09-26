namespace _23_3_Swap_Generics_LIFO;
//REVIEW - class Program
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
                
                Generic classes 

                Generic Typen können auch mit Klassen verwendet werden.


                Die häufigste Verwendung von allgemeinen Klassen findet
                bei Sammlungen von Elementen statt,
                bei denen Operationen wie das Hinzufügen und Entfernen von
                Elementen aus der Sammlung im Grunde genommen
                auf die gleiche Weise durchgeführt werden,
                unabhängig von der Art der gespeicherten Daten.
                Eine Art von Sammlung wird Stapel genannt.
                Elemente werden gepusht, oder zur Sammlung hinzugefügt
                und gepopped, oder aus der Sammlung entfernt.
                Ein Stapel wird manchmal als
                    
                    Last In First Out (LIFO)
                    
                Datenstruktur bezeichnet.

                class Stack<T>
                    {
                      int index      = 0; 
                      T[] innerArray = new T[100];

                      public void Push(T item)   { innerArray[index++] = item; }
                      public T Pop()            { return innerArray[--index];  }
                      public T Get(int k)      { return innerArray[k]; }
                    }

                Die generische Klasse speichert Elemente in einem Array.
                Wie Sie sehen können, wird der generische Typ T
                als der Typ des Arrays, der Parametertyp für die Push Methode
                und der Rückgabetyp für die Pop und Get Methoden verwendet.

                Jetzt können wir Objekte unserer generischen Klasse erstellen:

                    Stack<int> intStack = new Stack<int>();
                    Stack<string> strStack = new Stack<string>();
                    Stack<Person> PersonStack = new Stack<Person>();

                Wir können auch die generische Klasse mit benutzerdefinierten
                Typen verwenden, wie zum Beispiel dem benutzerdefinierten Person Typ.

                Info:

                In einer generischen Klasse müssen wir den
                generischen Typ für ihre Methoden nicht definieren,
                da der generische Typ bereits auf der Klassenebene definiert ist.
                

            **************************************************************************");
    
        
        
        //SECTION - Object intStack
        Stack<int> intStack = new Stack<int>();
            intStack.Push(3);
            intStack.Push(6);
            intStack.Push(7);
            
            //SECTION - Get the top element
            Console.WriteLine(intStack.Get(0)); 
            
    
    
    }
}

//REVIEW - class Stack
public class Stack<T>
{
    //SECTION - var Initialisierung
    int index = 0;
    T[] innerArray = new T[100] ;


    //SECTION - Push to stack
    public void Push (T item) {innerArray[index++] = item;}

    //SECTION - PoP from stack 
    public T   Pop (T item) {return innerArray[--index] ;}

    //SECTION - Get from stack
    public T Get (int k ) {return innerArray[k];}
}