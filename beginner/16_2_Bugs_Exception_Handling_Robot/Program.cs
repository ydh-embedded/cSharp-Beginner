using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_2_Bugs_Exception_Handling_Robot;

class Program
{
    static void Main(string[] args)
    {
            Console.WriteLine(@"

            **************************************************************************

                Multi Exception Handling

                Roboter-Barkeeper 

                Sie haben einen Roboter-Barkeeper und sein Ziel ist es,
                Getränke ordentlich auf den Regalen der Bar zu arrangieren.
                Er ist sehr klug und nimmt so viele Getränke, wie notwendig sind,
                um sie gleichmäßig auf den Regalen zu verteilen,
                hat aber immer noch Probleme mit der Division.

                Das im Roboter installierte Programm nimmt die Anzahl der Getränke
                und die Anzahl der Regale als Eingabe.

                Vervollständigen Sie das Programm,
                um die Getränke gleichmäßig auf den Regalen zu verteilen:
                indem Sie die Anzahl der Getränke durch die Anzahl
                der Regale teilen und das Ergebnis ausgeben.

                Das Programm muss auch diese beiden möglichen Probleme behandeln:

                1. der Teiler (die Anzahl der Regale) darf niemals null sein
                2. beide Eingaben sollten Ganzzahlen sein.
                Für die erste Ausnahme sollte das Programm
                Mindestens 1 Regal ausgeben und für die zweite, Bitte geben Sie eine Ganzzahl ein.

                
                    Beispieleingabe
                                        6
                                        zwei
                    Beispielausgabe
                                        Bitte geben Sie eine Ganzzahl ein
                
                    Info:

                Für robuste Programmierung anzuwenden,
                werden folgende Ausnahmetypen am häufigsten verwendeten:
                
                    FileNotFoundException,
                    FormatException,
                    IndexOutOfRangeException,
                    InvalidOperationException,
                    OutOfMemoryException.

                Tipp:

                Verwenden Sie für die erste Ausnahme
                
                    DivideByZeroException
                
                und für die zweite:

                     FormatException

                

            **************************************************************************");
          



//REVIEW - Try/Catch
            try
            {  
                // SECTION - Input Variables declaration
                Console.Write("Enter the number of drinks: ");
                    int drinks = Convert.ToInt32(Console.ReadLine());


                // SECTION - Input Variables declaration
                Console.Write("Enter the number of shelves: ");
                    int shelves = Convert.ToInt32(Console.ReadLine());


                //SECTION - Calculate the shelves with divid
                if (drinks % 2 == 0)
                {
                    int iSum = (int)drinks / (int)shelves;
                    System.Console.WriteLine("The result is: " + iSum);
                }
                else
                {
                    Console.WriteLine("At least 1 shelf" + message);
                }

            }

            //SECTION - Handle with formats
            catch ( FormatException ex)
            {
                System.Console.WriteLine("Please insert an integer " + ex.Message);
            }

            //SECTION - Handle with Divide By Null         
            catch ( DivideByZeroException ex)
            {
                System.Console.WriteLine("Cannot divide by zero. Please enter a valid shelf count." + ex.Message);
            }

            //SECTION - Handle with unexpected error         
            catch ( Exception ex)
            {
                System.Console.WriteLine("An unexpected error occurred. Please try again." + ex.Message);
            }



    }
}
