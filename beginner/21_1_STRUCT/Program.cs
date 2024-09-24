namespace _21_1_STRUCT;

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

                Structs 

                Ein struct-Typ ist ein Werttyp,
                der typischerweise verwendet wird,
                um kleine Gruppen verwandter Variablen zu verkapseln,
                wie beispielsweise die Koordinaten eines Rechtecks oder
                die Eigenschaften eines Artikels in einem Inventar.
                Das folgende Beispiel zeigt eine einfache Struct-Deklaration: 

                struct Book
                {
                    public string title;  
                    public double price;
                    public string author;
                }

                Structs teilen den größten Teil der Syntax mit Klassen,
                sind aber eingeschränkter als Klassen.

                Im Gegensatz zu Klassen können Structs ohne Verwendung
                eines neuen Operators instanziiert werden.

                Info: 

                Structs unterstützen keine Vererbung und
                können keine virtuellen Methoden enthalten.

                
                Structs vs Klassen 

                Im Allgemeinen werden Klassen verwendet,
                um komplexeres Verhalten oder Daten zu modellieren,
                die nach der Erstellung eines Klassenobjekts geändert werden sollen.
                Strukturen sind am besten für kleine Datenstrukturen geeignet,
                die hauptsächlich Daten enthalten,
                die nach der Erstellung der Struktur nicht geändert werden sollen.
                Überlegen Sie, eine Struktur anstelle einer Klasse zu definieren,
                wenn Sie versuchen, eine einfache Menge von Daten darzustellen.

                Alle Standard-C#-Typen (int, double, bool, char, usw.)
                sind tatsächlich Strukturen.




                

            **************************************************************************");

            Book b;
            b.title  =  "Test";
            b.price  =    5.99;
            b.author = "David";
            
            Console.WriteLine(b.title);

            Point p = new Point(10, 15);
            Console.WriteLine(p.x);
    }
}

//REVIEW - Struct Book
struct Book
{
   public string title;  
   public double price;
   public string author;
}

//REVIEW - Struct Point
struct Point
{
    public int x;
    public int y;
    public Point(int x, int y)
    {
                this.x = x;
                this.y = y;
    }
}