namespace ClassicInterfaces;

public class FancyTerminal : ITerminal
{
	private int lineCounter;

	public void Clear()
	{
		Console.Clear();
	}

	public void PrintLine(string line)
	{
		lineCounter++;
		Console.ForegroundColor = ConsoleColor.Yellow;
		Console.Write($"{lineCounter:D2}: ");
		Console.ResetColor();
		Console.WriteLine(line);
	}

	public FancyTerminal()
	{
		lineCounter = 0;
	}
}
