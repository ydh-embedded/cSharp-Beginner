namespace Interfaces;

class Program
{
	static void Main(string[] args)
	{
		LaserLexmarkDriver lexmarkZ100 = new("Lexmark Z100", supportsColor: true);
		LaserLexmarkDriver lexmarkB100 = new("Lexmark B100", supportsColor: false);
		InkjetEpsonDriver epsonColor = new("Epson Color");

		Application app = new(lexmarkZ100);
		app.Run();

		CoffeeMachine tchibo = new("A1234", 123456);
		// Zugriff auf explizit implementierte Interface-Member durch
		// Konvertierung in entsprechendes Interface.
		Console.WriteLine($"Save-ID: {(tchibo as ISaveable).ID}");
		Console.WriteLine($"ID: {(tchibo as IIdentifiable).ID}");

		ISaveable aSaveableObject = tchibo; // Up-Cast
		Console.WriteLine($"Save-ID: {aSaveableObject.ID}");
	}
}
