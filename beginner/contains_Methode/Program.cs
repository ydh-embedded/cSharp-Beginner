namespace contains_Methode;

class Program
{
    static void Main(string[] args)
    {
            Console.WriteLine(@"

    **************************************************************************

    PRACTICE EXERCISE
    Wörter 
    Das Ihnen gegebene Programm definiert ein Array
    mit 10 Wörtern und nimmt einen Buchstaben als Eingabe.

    Schreiben Sie ein Programm,
    um durch das Array zu iterieren und Wörter auszugeben,
    die den eingegebenen Buchstaben enthalten.

    Wenn es kein solches Wort gibt, sollte das Programm No match ausgeben.
    
    **************************************************************************");

        {
            string[] words = {
                "home",
                "programming",
                "victory",
                "C#",
                "football",
                "sport",
                "book",
                "learn",
                "dream",
                "fun"
            };

            Console.Write("Enter a letter: ");
            string letter = Console.ReadLine();

            int count = 0;

            foreach (string word in words)
            {
                if (word.ToLower().Contains(letter.ToLower()))
                {
                    Console.WriteLine(word);
                    count++;
                }
            }

            if (count > 0)
            {
                // Console.WriteLine($"Found {count} words containing the letter '{letter}'");
                Console.WriteLine($"");
            }
            else
            {
                Console.WriteLine("No match found");
            }
        }
    }
}