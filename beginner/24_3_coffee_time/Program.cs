using System;

using System.Collections.Generic;
using System.Globalization;

namespace _24_3_coffee_time
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print Lesson Header
            PrintHeader();
                
            // Init Input
            Console.Write("Enter discount percentage: ");
            int discount = Convert.ToInt32(Console.ReadLine());

            // Initialize Dictionary
            Dictionary<string, double> coffee = new Dictionary<string, double>
            {
                { "Americano",      50 },
                { "Latte",          70},
                { "Flat White",     60},
                { "Espresso",       60},
                { "Cappuccino",     80},
                { "Mocha",          90}
            };

            // Print discounted prices
            foreach (var coffeeType in coffee.Keys)
            {
                double originalPrice = coffee[coffeeType];
                double discountedPrice = originalPrice - (originalPrice * discount / 100);
                
                // Check if the discounted price is a whole number
                if (discountedPrice % 1 == 0)
                {
                    // Print as integer
                    Console.WriteLine($"{coffeeType}: {((int)discountedPrice)}"); // Cast to int
                }
                else
                {
                    // Print with 1 decimal place
                    Console.WriteLine($"{coffeeType}: {discountedPrice.ToString("F1", CultureInfo.InvariantCulture)}");
                }
            }
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
                
            ");
            Console.ResetColor(); // Reset to default color
        }
    }
}