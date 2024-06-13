namespace NullPointerException;

public class Program
{
    public static void Main(string[] args)
    {
        ClassofPerson person = null;
        string name = person?.Name ?? "Unknown";
        Console.WriteLine(name); // Prints "Unknown"
    }
}