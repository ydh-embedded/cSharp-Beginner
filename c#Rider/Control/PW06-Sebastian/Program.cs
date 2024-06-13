using System.Text;
using System.Runtime.InteropServices;

namespace Strings;

internal partial class Program
{
    [DllImport("msvcrt.dll")]
    public static extern int system(string cmd);
    static readonly int lineWidth = Console.BufferWidth;
    static readonly int windowHeight = Console.BufferHeight;
    static readonly string border = new('=', ((lineWidth - 26) / 2));
    static readonly string programName = $"\n\n{border}    PASSWORD GENERATOR    {border}";
    static readonly string licenseText = new string(' ', ((lineWidth - 10) / 2)) + "(freeware)";
    static readonly string goodbyeText = new string(' ', ((lineWidth - 26) / 2)) + "***   End of Program   ***\n";
    static readonly string errorMessage = "System.ArgumentException: Value does not fall within the expected range.";
    static readonly string errorSpacing = new(' ', (lineWidth - 72) / 2);

    static void Main(string[] args)
    {
        system("cls");

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine(programName);
        Console.WriteLine(licenseText);
        Console.ForegroundColor = ConsoleColor.DarkCyan;

        int size = args.Length;
        if (size > 0)
        {
            int paddingVertical = (windowHeight - 8 - size) / 2;
            string spacingVertical = new('\n', paddingVertical > 1 ? paddingVertical : 2);
            Console.Write($"{spacingVertical}");
            foreach (string argument in args)
            {
                if (int.TryParse(argument, out int length)) { Console.WriteLine(GeneratePassword(length)); }
            }
            Console.Write(size % 2 == 1 ? $"\n{spacingVertical}" : $"{spacingVertical}");
        } else
        {
            string spacingVertical = new('\n', (windowHeight - 8 - 6) / 2);
            Console.Write($"{spacingVertical}");
            Console.WriteLine(GeneratePassword(15));
            Console.WriteLine(GeneratePassword(20));
            Console.WriteLine(GeneratePassword(17));
            Console.WriteLine(GeneratePassword(21));
            Console.WriteLine(GeneratePassword(36));
            Console.WriteLine(GeneratePassword(25));
            Console.Write($"{spacingVertical}");
        }

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine(goodbyeText);

        Console.WriteLine("Fuck the police");
        Console.ReadKey();
        
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
        string paddingHorizontal = new(' ', ((lineWidth - n) / 2));

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

            return string.Concat(paddingHorizontal, passShuffled);
        }
        catch (ArgumentException e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n{string.Concat(errorSpacing, errorMessage)}");
            Console.WriteLine($"{string.Concat(errorSpacing, e.Message)}\n");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
        }
        return "";
    }
}