namespace _15_3_Veerbung_Destruktor_II;

class Program
{
    static void Main(string[] args)
    {
            //NOTE - Header
            Console.WriteLine(@"

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

            

            **************************************************************************

                Veerbung - Destruktor Bsp. Flughafen

                Sie sind der Flughafenverwalter,
                der für die Festlegung der Flugstatus verantwortlich ist.

                Zunächst zeigte das Flugprogramm nur die 
                Status Registration und Closed, aber wir müssen es erweitern,
                um detailliertere Informationen zu liefern.

                Leiten Sie die WayStatus Klasse von der Flight Klasse ab und
                vervollständigen Sie

                1. den Konstruktor, um On the way auszugeben

                2. den Destruktor, um Landed auszugeben

                damit das Programm korrekt alle Status des Fluges ausgibt.

                Wichtig:

                Denken Sie daran,
                dass beim Erstellen eines abgeleiteten Klassenobjekts
                auch der Konstruktor und der Destruktor der
                Basisklasse aufgerufen werden - der Konstruktor wird am Anfang und
                der Destruktor am Ende aufgerufen.

                Hier ein Typisches Problem:

                Das Problem ist, dass die
                Destruktoren (~Flight() und ~WayStatus()) nicht automatisch aufgerufen
                werden, wenn die Objekte den Anwendungsbereich verlassen.

                In C# wird nicht garantiert,
                dass Destruktoren (auch bekannt als Finalizer)
                sofort aufgerufen werden, wenn ein Objekt nicht mehr referenziert wird.
                Stattdessen wird der Garbage Collector schließlich den Destruktor aufrufen,
                wenn er beschließt, den vom Objekt belegten Speicher freizugeben.

                Um die Destruktoren in Aktion zu sehen,
                müssen Sie den Garbage Collector dazu zwingen, zu laufen,
                indem Sie GC.Collect() und GC.WaitForPendingFinalizers() aufrufen,
                nachdem die Objekte den Gültigkeitsbereich verlassen haben.

            **************************************************************************");


            //NOTE - Main
            
        WayStatus status = new WayStatus();
        status.OnTheWay(); // Call OnTheWay() method

        // Force garbage collection to run
        GC.Collect();
        GC.WaitForPendingFinalizers();
    }
}

//NOTE - Base Class Flight

class Flight
{
    public Flight() => Console.WriteLine("Registration");     //Constructor

    ~Flight() => System.Console.WriteLine("Closed");         //Destructor
}


//NOTE - class WayStatus
class WayStatus : Flight
{
    public void OnTheWay() => System.Console.WriteLine("On the way");
    
    ~WayStatus() => System.Console.WriteLine("Landed");
}
