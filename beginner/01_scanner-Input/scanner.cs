using System;
using System.IO;

public class StandardStreams
{
    public static void Main()
    {
        Console.WriteLine("Daten von Standard Output Stream");   // writes to the standard output stream
        Console.Error.WriteLine("Daten von Standard Error Stream");   // writes to the standard error stream

        // create a new Scanner and read from the standard input stream
        using var scanner = new Scanner(Console.In);
        string input = scanner.ReadLine();
        Console.WriteLine("You entered: " + input);
    }
}

// custom Scanner class for simple console input in C#
public class Scanner : IDisposable
{
    private TextReader _reader;

    public Scanner(TextReader reader)
    {
        _reader = reader;
    }

    public string ReadLine()
    {
        return _reader.ReadLine();
    }

    public void Dispose()
    {
        _reader.Dispose();
    }
}