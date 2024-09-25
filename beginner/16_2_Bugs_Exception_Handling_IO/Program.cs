using System.IO;

namespace _16_2_Bugs_Exception_Handling_IO;
//REVIEW - class Program
class Program
{
    static void Main(string[] args)
    {

            Console.WriteLine(@"

            **************************************************************************

                Multi Exception Handling

                In diesem Beispiel werden die Datei-E/A-Vorgänge in
                einen Try-Block eingeschlossen.
                Wir fangen dann vier Arten von Ausnahmen ab:

                DirectoryNotFoundException:
                    wird ausgelöst,
                    wenn das im Dateipfad angegebene Verzeichnis nicht vorhanden ist.

                FileNotFoundException:
                    wird ausgelöst,
                    wenn die im Dateipfad angegebene Datei nicht vorhanden ist.

                IOException:
                    wird ausgelöst,
                     wenn während der Datei-E/A-Operationen ein Fehler auftritt,
                    z. B. Berechtigungsprobleme oder Festplattenfehler.

                Exception:
                    ein Auffangbecken für alle anderen unerwarteten Fehler,
                    die auftreten können.

                

                Info:

                Für robuste Programmierung anzuwenden,
                werden folgende Ausnahmetypen am häufigsten verwendeten:
                
                    FileNotFoundException,
                    FormatException,
                    IndexOutOfRangeException,
                    InvalidOperationException,
                    OutOfMemoryException.

                

            **************************************************************************");
                
//REVIEW - Try/Catch
        try 
        {
            //SECTION - Write File
            string str = " Some text";
            File.WriteAllText("test.txt", str);

            //SECTION - Read File
            string txt = File.ReadAllText("test.txt");
            System.Console.WriteLine(txt);
        } 
        
        catch      (DirectoryNotFoundException ex)                                  //SECTION - Message: Directory not found:
        {
            Console.WriteLine("Directory not found: " + ex.Message);
        }

        catch      (FileNotFoundException ex)                                       //SECTION - Message: File not found: 
        {
            Console.WriteLine("File not found: " + ex.Message);
        }

        catch      (IOException ex)                                                 //SECTION - Message: Error reading or writing file:
        {
            Console.WriteLine("Error reading or writing file: " + ex.Message);
        }

        catch      (Exception ex)                                                   //SECTION - Message: An unexpected error occurred: 
        {
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }

    }
}