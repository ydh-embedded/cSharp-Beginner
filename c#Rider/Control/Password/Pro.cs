using System.Text;

namespace Password;

internal class Pro
{
        const int lineWidth = 120;

        static void Main(string[] args)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            // Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\x1b[3J");
            Console.WriteLine("\n\n===============================================    PASSWORD GENERATOR    ===============================================");
            Console.WriteLine("                                                       (freeware)                                                       \n\n");

            if (args.Length > 0)
            {
                foreach (string argument in args)
                {
                    if (int.TryParse(argument, out int length)) { Console.WriteLine($"\t\t{GeneratePassword(length)}"); }
                } 
            } else
            {
                Console.WriteLine(GeneratePassword(15));
                Console.WriteLine(GeneratePassword(17));
                Console.WriteLine(GeneratePassword(20));
                Console.WriteLine(GeneratePassword(25));
                Console.WriteLine(GeneratePassword(36));
            }

            Console.WriteLine("\n\n                                               ***   End of Program   ***                                               \n");
        }

        static string GeneratePassword (int n)
        {
            StringBuilder password = new();
            Random rng = new();
            const string numbers        = "1234567890";
            const string literals       =@"!.-$#(,}])[{?\/";
            const string bigLetters     = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string smallLetters   = "abcdefghijklmnopqrstuvwxyz";
            string padding = new(' ', ((lineWidth - n) / 2));

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

                return (string.Concat(padding, passShuffled));
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("\n" + @"                          System.ArgumentException: Value does not fall within the expected range.");
                Console.WriteLine($@"                             {e.Message}" + "\n");
            }
            return "";
        }
    }
