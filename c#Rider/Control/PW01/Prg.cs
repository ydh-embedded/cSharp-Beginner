namespace PW01;
using System.Text;

public class Prg
{ 
    static void Main()
        {
            Console.WriteLine("\n\n===================   PASSWORD GENERATOR   ===================");
            Console.WriteLine("\t\t          (freeware)          \n\n");

            GeneratePassword(16);
            GeneratePassword( 7);
            GeneratePassword(14);
            GeneratePassword(10);
            GeneratePassword(12);

            Console.WriteLine("\n\n\t\t  ***   End of Program   ***\n");
        }

        static string? GeneratePassword (int n)
        {
            StringBuilder password = new();
            Random rng = new();
            
            const string numbers        = "1234567890";
            const string literals       = "!.-$#";
            const string bigLetters     = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string smallLetters   = "abcdefghijklmnopqrstuvwxyz";

            try
            {
                if (n < 8)
                {
                    throw new ArgumentException("Must be at least 8", nameof(n));
                }
                password.Append(literals[rng.Next(0, literals.Length)]);
                password.Append(bigLetters[rng.Next(0, bigLetters.Length)]);
                password.Append(literals[rng.Next(0, literals.Length)]);
                password.Append(numbers[rng.Next(0, numbers.Length)]);

                while (password.Length < n)
                {
                    password.Append(smallLetters[rng.Next(0, smallLetters.Length)]);
                }

                char[] passArray = password.ToString().ToCharArray();

                rng.Shuffle(passArray);

                string passShuffled = new(passArray);

                Console.WriteLine($"\tPasswort: {passShuffled}");

                return passShuffled;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("\n" + @"          System.ArgumentException: Value does not fall
                                    within the expected range.");
                Console.WriteLine($@"          {e.Message}" + "\n");
            }
            return null;
        }
    }

