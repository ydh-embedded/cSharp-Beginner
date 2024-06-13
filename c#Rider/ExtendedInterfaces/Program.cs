namespace ClassicInterfaces;

internal class Program
{
	static void Main(string[] args)
	{
		MonochromeTerminal monochrome = new();
		// Eine Default-Methode eines Interfaces ist nur über eine Interface
		// Variable aufrufbar, da Interfaces nichts vererben.
		(monochrome as ITerminal).SetCursor(2, 3);

		ITerminal terminal = new MonochromeTerminal();
		terminal.PrintRandomColoredLine("{0}={1} {0}", "X", 2);
		terminal.PrintRandomColoredLine("Das ist ");
		terminal.PrintLine("Das ist etwas Text");
		terminal = new FancyTerminal();
		terminal.PrintLine("Hello");
		terminal.PrintLine("World");
		terminal.PrintLine("C# is awesome!");

		terminal.PrintLine(Sum(1, 2, 3, 4, 5, 6).ToString());
		terminal.PrintLine(Sum(1, 2).ToString());
		terminal.PrintLine(Sum().ToString());

		terminal.PrintLine(ITerminal.GetRandomColor());
	}

	static int Sum(params int[] numbers)
	{
		int sum = 0;
		foreach (int n in numbers) sum += n;
		return sum;
	}
}
