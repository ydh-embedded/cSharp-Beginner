namespace _24_3_coffee_time;

class Program
{
    static void Main(string[] args)
    {

            PrintHeader();
            
            int discount = Convert.ToInt32(Console.ReadLine());

            Dictionary<string, double> coffee = new Dictionary<string, double>();
            coffee.Add("Americano", 50);
            coffee.Add("Latte", 70);
            coffee.Add("Flat White", 60);
            coffee.Add("Espresso", 60);
            coffee.Add("Cappuccino", 80);
            coffee.Add("Mocha", 90);


            //your code goes here
    }


    static void PrintHeader()
    {
        // Change color for header
        Console.ForegroundColor = ConsoleColor.Cyan; 
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

                    Coffee Time

                Ein Café-Manager führt eine Promotion durch und möchte einen
                Rabatt für Kaffeegetränke anbieten.

                Das Programm, das Sie erhalten, nimmt den Rabattwert als Eingabe
                und definiert ein Wörterbuch, in dem die Namen der Kaffeegetränke
                als Schlüssel und deren Preise als Werte festgelegt sind.

                Schreiben Sie ein Programm, um alle Preise zu reduzieren
                und eine neue Preisliste im unten gezeigten Format auszugeben.

                Beispieleingabe

                    10

                Beispielausgabe

                    Americano:  45
                    Latte:      63
                    Flat White: 54
                    Espresso:   54
                    Cappuccino: 72
                    Mocha:      81



                Info:

                Verwenden Sie coffee.Keys.ToArray() innerhalb der foreach-Schleife.
                Achten Sie auf das Leerzeichen nach dem : in der Ausgabe.
                

            **************************************************************************");
            Console.ResetColor();                                         // Reset to default color
    }
        
    static void PrintDictionary(Dictionary<string, int> dictionary)
    {
        // Print header
        Console.ForegroundColor = ConsoleColor.Cyan;                    // Change color for header
        Console.WriteLine("Key\t\tValue");
        Console.ResetColor();                                         // Reset to default color
        
        // Print Dashes
        Console.ForegroundColor = ConsoleColor.Yellow;               // Change color for dashes
        Console.WriteLine("---------------------");
        Console.ResetColor();                                       // Reset to default color

        // Print each key-value pair
        foreach (var kvp in dictionary)
        {
            Console.WriteLine($"{kvp.Key}\t\t{kvp.Value}");
        }

        Console.ForegroundColor = ConsoleColor.Yellow;           // Change color for dashes
        Console.WriteLine("---------------------");
        Console.ResetColor();                                   // Reset to default color
    }
}
