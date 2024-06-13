namespace ClassicInterfaces;

interface ITerminal
{
	// public abstract void PrintLine(string line);
	void PrintLine(string line);
	// public abstract void Clear();
	void Clear();

	// Diese Methode wurde nachträglich hinzugefügt.
	// Es handelt sich um eine Default-Implementierung.
	void SetCursor(int row, int column)
	{
		throw new InvalidOperationException();
	}

	// Diese Methode wurde ebenfalls nachträglich hinzugefügt.
	// Sie verwendet statische Methoden und statische Felder.
	// Hinweis: Parameter arguments ist ein variadischer Parameter, d.h.
	// er sammelt alle restlichen Argumente ein und stellt sie als
	// Array in der Methode zur Verfügung.
	void PrintRandomColoredLine(string format, params object[] arguments)
	{
		Console.ForegroundColor = GetRandomColor();
		Console.WriteLine(format, arguments);
		Console.ResetColor();
	}

	void PrintLine(object o)
	{
		PrintLine(o.ToString() ?? "<null>");
	}

	// Auch statische Felder und statische Methoden dürfen ab C# 8
	// verwendet werden, um Default-Implementierungen zu programmieren.
	private const int defaultBufferSize = 1024;
	private static readonly Random randomizer = new();
	public static ConsoleColor GetRandomColor()
	{
		ConsoleColor[] colors = [ConsoleColor.Red, ConsoleColor.Green, ConsoleColor.Blue];
		return colors[randomizer.Next(colors.Length)];
	}

}
