namespace _25_0_Dictionary;

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
                
                Dictionary<U, V> 
 
            Ein Wörterbuch ist eine Sammlung von eindeutigen Schlüssel/Wert-Paaren,
            bei denen ein Schlüssel zum Zugriff auf den entsprechenden Wert verwendet wird.
            Wörterbücher werden bei der Datenbankindizierung,
            Cache-Implementierungen usw. verwendet.

            Die C# generische Sammlung Dictionary<K, V> Klasse erfordert,
            dass alle Schlüssel/Wert-Paare vom gleichen Typ K, V sind.
            Doppelte Schlüssel sind nicht erlaubt, um sicherzustellen,
            dass jedes Schlüssel/Wert-Paar eindeutig ist.

                Dictionary<K, V> Eigenschaften beinhalten:

            Count - Ruft die Anzahl der Schlüssel/Wert-Paare ab,
                    die im Wörterbuch enthalten sind.
            
            Item[K key] - Ruft den Wert ab, der mit dem angegebenen Schlüssel
                          im Wörterbuch verknüpft ist. Item ist der Indexer
                          und ist nicht erforderlich, wenn auf ein Element zugegriffen wird.
                          Sie müssen nur die Klammern [] und den Schlüsselwert verwenden.

            Keys - Ruft eine indizierte Sammlung ab, die nur die im Wörterbuch
                    enthaltenen Schlüssel enthält.

                
                Dictionary<K, V> Methoden beinhalten:

Add(K key, V value) - Fügt das Schlüssel-, Wert-Paar zum Wörterbuch hinzu.

Remove(K key) - Entfernt das Schlüssel/Wert-Paar, das mit dem angegebenen Schlüssel aus dem Wörterbuch in Beziehung steht.
                

            **************************************************************************");

        // Initialize Dictionary
        Dictionary<string, int> d = new Dictionary<string, int>();
        d.Add("Uno", 1);
        d.Add("One", 1);
        d.Add("Dos", 2);
        d.Add("Deux", 2);
        
        // Remove items from the dictionary
        d.Remove("One"); // Remove key-value pair One, 1
        d.Remove("Dos"); // Remove key-value pair Dos, 2

        // Print Dictionary in Table Format
        Console.WriteLine("=== Dictionary ===");
        PrintDictionary(d);
        Console.WriteLine("\nCount: {0}", d.Count); // Total count    
		
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
