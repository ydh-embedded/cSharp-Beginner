namespace _23_3_Swap_Generics_LIFO_II;
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

                Die Klasse Elems erstellt ein 3-großes Array
                von Ganzzahlen, definiert die Methode Add() und die Methode Show(),
                
                um die Elemente in das Array zu speichern und
                zeigt sie getrennt durch ein Leerzeichen an.

                Ändern Sie die Klasse, um sie allgemein zu gestalten,
                um die gleichen Aktionen mit dem String-Typ auszuführen,
                der in der Main-Funktion gegeben ist.

                Tipp:

                Sie müssen den int Typ durch den generischen <T> Typ ersetzen.
                Jede Ausgabe sollte mit einem Leerzeichen enden.
                

            **************************************************************************");
    
        
        
        //SECTION - Object intStack
        // Stack<int> intStack = new Stack<int>();


            //SECTION - string Object elemn1 (stack with iElements of Names)
            Elems<string> sElems_1 = new Elems<string>();
            sElems_1.Add("John", "Tamara", "David");

            sElems_1.Show();

            Console.WriteLine();

            //SECTION - string Object elemn2 (stack with iElements of Numbers)
            Elems<int> sElems_2 = new Elems<int>();
            sElems_2.Add(5, 14, 13);

            sElems_2.Show();

    
    }
}

//REVIEW - class Stack
public class Stack<T>
{
    //SECTION - var Initialisierung
    private T[] innerArray = new T[100] ;
    private int index = 0;


    //SECTION - Push to stack
    public void Push (T item) {innerArray[index++] = item;}

    //SECTION - PoP from stack 
    public T   Pop ( ) {return innerArray[--index] ;}

    //SECTION - Get from stack
    public T Get (int k ) {return innerArray[k];}
}



//REVIEW - class Elems
public class Elems <T>
{
    public int[] iElements = new int[3];

    private T[] iElements;

    //SECTION - Constructor Elemns  Constructors are used to set the initial state of an object when it is created
    public Elems(int size)
    {
        iElements = new T[size];
    }



    //SECTION - Method Add 
    public void Add(params T[] elements)
    {
        for (int i = 0; i < elements.Length; i++)
        {
            iElements[i] = elements[i];
        }
    }



    //SECTION - Method Show
    public void Show()
    {
        foreach (T item in iElements)
        {
            Console.Write(item + " ");
        }
    }



}