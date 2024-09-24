namespace _21_2_STRUCT_Quader;

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

                Ein Quader ist eine dreidimensionale Form mit einer
                Länge, Breite und Höhe.

                Das gegebene Programm nimmt diese Dimensionen als Eingaben,
                definiert die Cuboid-Struktur und erstellt deren Objekt. 

                Vervollständigen Sie das Programm,
                indem Sie einen Konstruktor erstellen,
                der die Länge, die Breite und die Höhe als
                Parameter nimmt und sie den Strukturmitgliedern zuweist. 

                Vervollständigen Sie auch die Methoden
                Volume() und Perimeter() innerhalb der Struktur,
                um sie zu berechnen und zurückzugeben,
                damit die gegebenen Methodenaufrufe korrekt funktionieren.


                Sample Input

                5
                4
                5

                Sample Output
                
                Volume: 100
                Perimeter: 56

                Info:

                Quader Volumen: Länge * Breite * Höhe.
                Quader Umfang: 4 * (Länge + Breite + Höhe).


                

            **************************************************************************");

            int iChoice;
            do
            {
                System.Console.WriteLine("Enter the Units of Measurement: ");
                System.Console.WriteLine("1. mm");
                // System.Console.WriteLine("2. cm");
                // System.Console.WriteLine("3. m");
                System.Console.WriteLine("Choose an Option: ");

                if (!int.TryParse(System.Console.ReadLine(), out iChoice) || iChoice < 1 || iChoice > 3 )  
                {
                    System.Console.WriteLine("Invalid Input");
                    continue;
                }
                
                int iLength , iWidth , iHeight ;        //SECTION - We declair the var outside of the switch for better maintain and the method volume and Perimeter can call the values from outs
                switch (iChoice)
                {
                    
                    case 1:

                            System.Console.WriteLine("Enter the Lenght of Cubi in mm: ");
                            iLength = Convert.ToInt32(Console.ReadLine());

                            System.Console.WriteLine("Enter the Widht of Cubi in mm: ");
                            iWidth  = Convert.ToInt32(Console.ReadLine());

                            System.Console.WriteLine("Enter the Height of Cubi in mm: ");
                            iHeight = Convert.ToInt32(Console.ReadLine());
                    
                            Cuboid iCuboid = new Cuboid(iLength, iWidth, iHeight);

                            Console.WriteLine("Volume: " + iCuboid.Volume() + " mm³");
                            Console.WriteLine("Perimeter: " + iCuboid.Perimeter() + " mm");


                            break;

                    case 2:

                            //NOTE - same code from upper with calc in cm

                    case 3:
                    
                            //NOTE - same code from upper with calc in cm

                    default:
                            
                            System.Console.WriteLine("Invalid Input");      
                            
                            break;

                }
            } while (true);








    }
}


//REVIEW - struct Cuboid
struct Cuboid
{
    public int length;
    public int width;
    public int height;


                                                            //SECTION - create a constructor
    public Cuboid ( int length , int width , int height)
    {
        this.length = length;
        this.width  =  width;
        this.height = height;
    }
        
                                                            //SECTION - complete this method
    public int Volume( )
    {
        return length * width * height;                   //SECTION - the Volume method is using the instance fields length, width, and height to calculate the volume. The result is returned directly, without any intermediate variables or parameters.
    }
                                                            //SECTION - complete this method
    public int Perimeter( )
    {
        return 4 * ( length + width + height );
    }
}