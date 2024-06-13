namespace ClassicInterfaces;

public class MonochromeTerminal : ITerminal
{
	public void Clear()
	{
		Console.Clear();
	}

	public void PrintLine(string line)
	{
		Console.ForegroundColor = ConsoleColor.Black;
		Console.BackgroundColor = ConsoleColor.White;
		Console.WriteLine(line);
		Console.ResetColor();
	}

	// Diese Methode ersetzt die Default-Implementierung von
	// ITerminal.SetCursor.
	public void SetCursor(int row, int column)
	{
		Console.SetCursorPosition(column, row);
	}

}
