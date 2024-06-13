using System.Text.RegularExpressions;

namespace Password;

private record GetValidateInput();


private static string GetValidatedInput()
{
    Console.Write("Enter a password (min 8 characters, at least one uppercase, one lowercase, one digit, and one special character): ");
    string input = Console.ReadLine();

    const string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";
    Regex regex = new Regex(pattern);

    while (!regex.IsMatch(input))
    {
        Console.WriteLine("Invalid password. Please try again.");
        Console.Write("Enter a password (min 8 characters, at least one uppercase, one lowercase, one digit, and one special character): ");
        input = Console.ReadLine();
    }

    return input;
}