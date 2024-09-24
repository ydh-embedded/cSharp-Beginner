namespace _16_1_Bugs_Exception_Handling;

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

                Exception Handling


                Eine Exception Handling ist ein Problem,
                das während der Programmausführung auftritt.
                Ausnahmen führen zu einem abnormalen Beenden des Programms.

                Eine Ausnahme kann aus vielen verschiedenen Gründen auftreten.
                
                Einige Beispiele:

                - Ein Benutzer hat ungültige Daten eingegeben.
                - Eine Datei, die geöffnet werden muss, kann nicht gefunden werden.
                - Eine Netzwerkverbindung wurde mitten in der Kommunikation verloren.
                - Unzureichender Speicher und andere Probleme
                  im Zusammenhang mit physischen Ressourcen.

                Zum Beispiel wird der folgende Code eine Ausnahme erzeugen,
                wenn er ausgeführt wird,
                weil wir einen Index anfordern, der nicht existiert: 

                

                Info:

                Wie Sie sehen können, werden Ausnahmen durch Benutzerfehler,
                Programmierfehler oder Probleme mit physischen Ressourcen verursacht.
                Ein gut geschriebenes Programm sollte
                jedoch alle möglichen Exceptions behandeln.


                C# bietet einen flexiblen Mechanismus namens try-catch
                Anweisung zur Behandlung von Ausnahmen,
                damit ein Programm bei einem Fehler nicht abstürzt.

                Die try und catch Blöcke werden ähnlich wie folgt verwendet: 

                Der Code, der eine Ausnahme erzeugen könnte, wird im try Block platziert.
                Wenn eine Ausnahme auftritt, wird der catch-Block ausgeführt,
                ohne das Programm zu stoppen.

                Die Art der Ausnahme, die Sie abfangen möchten,
                erscheint in Klammern nach dem Schlüsselwort catch.

                Wir verwenden den allgemeinen Exception-Typ,
                um alle Arten von Ausnahmen zu verarbeiten.
                Wir können auch das Ausnahmeobjekt e verwenden,
                um auf die Details der Ausnahme zuzugreifen,
                wie zum Beispiel die ursprüngliche Fehlermeldung (e.Message):


                

            **************************************************************************");


                    try
                     {
                        int[] arr = new int[] { 4, 5, 8 };
                        Console.Write(arr[8]);
                     } catch(Exception e) {
                        Console.WriteLine(An error occurred);
                    }

            Console.WriteLine(@"

            **************************************************************************

                Multi Exception Handling




                

                Info:

                Die folgenden Ausnahmetypen
                sind einige der am häufigsten verwendeten:
                
                FileNotFoundException,
                FormatException,
                IndexOutOfRangeException,
                InvalidOperationException,
                OutOfMemoryException.

                

            **************************************************************************");
                
                int x, y;

                
                    try {
                      x = Convert.ToInt32(Console.Read());
                      y = Convert.ToInt32(Console.Read());
                      Console.WriteLine(x / y);
                    }
                     catch (DivideByZeroException e) {
                      Console.WriteLine("Cannot divide by 0");
                    }
                     catch(Exception e) {
                      Console.WriteLine("An error occurred");
                    }





    }
}
