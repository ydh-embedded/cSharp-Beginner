namespace _20_0_verschachtelte_classen;

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
            @@@@@%%%#################+=---------------------=+*###############%%%%@@@@@
            @@@@@@@@@%%%%###############*++=-----------==+*###############%%%%@@@@@@@@
            @@@@@@@@@@@@@%%%###############%%#########################%%%%@@@@@@@@@@@@
            @@@@@@@@@@@@@@@@%%%%###################################%%%%@@@@@@@@@@@@@@@
            @@@@@@@@@@@@@@@@@@@@%%#############################%#%%%@@@@@@@@@@@@@@@@@@
            @@@@@@@@@@@@@@@@@@@@@@%%#%#######################%%%%@@@@@@@@@@@@@@@@@@@@@
            @@@@@@@@@@@@@@@@@@@@@@@@@@%%%%#################%@@@@@@@@@@@@@@@@@@@@@@@@@@
            @@@@@@@@@@@@@@@@@@@@@@@@@@@@@%%%%#########%%%%%@@@@@@@@@@@@@@@@@@@@@@@@@@@
            @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%%%####%%%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@

            

            **************************************************************************

                Verschachtelte Klassen
                
                C# unterstützt verschachtelte Klassen:
                eine Klasse, die Mitglied einer anderen Klasse ist.

                Zum Beispiel:
                class Car
                {
                 string name;
                    public Car(string nm)
                    {
                          name = nm;
                          Motor m = new Motor();
                    }

                 public class Motor
                 {
                        // some code
                 }
                }

                Die Motor Klasse ist in die Auto Klasse eingebettet und
                kann ähnlich wie andere Mitglieder der Klasse verwendet werden.

                Eine eingebettete Klasse fungiert als Mitglied der Klasse,
                daher kann sie die gleichen Zugriffsmodifizierer
                wie andere Mitglieder haben (public, private, protected).

                Info:

                Genau wie im echten Leben können Objekte andere Objekte enthalten.
                Zum Beispiel kann ein Auto,
                das seine eigenen Attribute hat (Farbe, Marke, etc.)
                einen Motor enthalten, der als separates Objekt seine
                eigenen Attribute hat (Volumen, Pferdestärken, etc.).
                Hier kann die Car-Klasse eine verschachtelte Motor-Klasse als
                eines ihrer Mitglieder haben.

                containing class with the nested class



            **************************************************************************");

        // Create an instance of the OuterClass
        OuterClass outer = new OuterClass();

        // Create an instance of the NestedClass using the OuterClass instance
        OuterClass.NestedClass nested = new OuterClass.NestedClass();

        // Now you can access the methods
        outer.DoSomethingElse();
        nested.DoSomething();

    }
}



//REVIEW - Contained class
public class OuterClass
{
    private int outerField;


    //REVIEW - Nested class

    public class NestedClass
    {
        private int nestedField;

        public void DoSomething()
        {
            Console.WriteLine("Nested class method");
            System.Console.WriteLine(   "");
        }
    }

    public void DoSomethingElse()
    {
        Console.WriteLine("Outer class method");
    }
}
