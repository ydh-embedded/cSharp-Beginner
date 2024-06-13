using System.Text.RegularExpressions;

namespace Password;

record GeneratePasswordRegex(int n);

    const string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";
    Regex regex = new Regex(pattern);

    string password;
    do
    {
        password = GeneratePassword(n);
    } while (!regex.IsMatch(password));

    return password;
