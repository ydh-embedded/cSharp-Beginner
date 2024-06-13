using System.Text.RegularExpressions;

namespace PW03;

public class Pro
{

        static void Main(string[] args)
        {
            Console.Write("Enter the desired length of the password: ");
            string input = Console.ReadLine();
            int n = int.Parse(input);

            // string password = GeneratePasswordRegex(n);

            // Console.WriteLine($"\nGenerated password: {password}");
            Console.ReadLine();
        }

        // static string GeneratePasswordRegex(int n)
        // {
        //     const string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";
        //     Regex regex = new Regex(pattern);
        //
        //     string password;
        //     do
        //     {
        //         password = GeneratePassword(n);
        //     } while (!regex.IsMatch(password));
        //
        //     return password;
        // }


}