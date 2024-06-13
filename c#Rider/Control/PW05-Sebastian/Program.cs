using System.Text;

namespace PW05
{
    internal class Program
    {
        static readonly int lineWidth = Console.BufferWidth;
        static readonly string border = new('=', ((lineWidth - 26) / 2));
        static readonly string programName = $"\n\n{border}    PASSWORD GENERATOR    {border}";
        static readonly string licenseText = new string(' ', ((lineWidth - 10) / 2)) + "(freeware)\n\n";
        static readonly string goodbyeText = "\n\n" + new string(' ', ((lineWidth - 26) / 2)) + "***   End of Program   ***\n\n\n\n\n\n";
        static readonly string errorMessage = "System.ArgumentException: Value does not fall within the expected range.";
        static readonly string errorSpacing = new(' ', ((lineWidth - 72) / 2));

        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("\x1b[3J");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(programName);
            Console.WriteLine(licenseText);

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            if (args.Length > 0)
            {
                foreach (string argument in args)
                {
                    if (int.TryParse(argument, out int length)) { Console.WriteLine(GeneratePassword(length)); }
                } 
            } else
            {
                Console.WriteLine(GeneratePassword(13));
                Console.WriteLine(GeneratePassword(17));
                Console.WriteLine(GeneratePassword(20));
                Console.WriteLine(GeneratePassword(25));
                Console.WriteLine(GeneratePassword(36));
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(goodbyeText);

            Console.ForegroundColor = ConsoleColor.DarkGray;
        }

        static string GeneratePassword (int n)
        {
            StringBuilder password = new();
            Random rng = new();
            const string numbers        = "1234567890";
            const string literals       = "!.-$#(,}])[{?\\/";
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

                return string.Concat(padding, passShuffled);
            }
            
            catch (ArgumentException e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\n{string.Concat(errorSpacing, errorMessage)}");
                Console.WriteLine($"{string.Concat(errorSpacing, e.Message)}\n");
            }
            return "";
        }
    }
}