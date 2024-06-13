
namespace Interfaces;

class InkjetEpsonDriver : IPrinterDriver
{
	public string PrinterType => "Inkjet";

	public bool SupportsDuplex => true;

	public bool SupportsColor => true;

	public int MaxDotsPerInch => 300;

	public bool PrintColoredText(string text, ConsoleColor color)
	{
		Console.ForegroundColor = color;
		Console.WriteLine(text);
		Console.ResetColor();
		return true;
	}

	public bool PrintText(string text)
	{
		Console.WriteLine(text);
		return true;
	}

	public string GetDiagnosticData() => "Everything ok";

	public string DeviceName { get; }

	public InkjetEpsonDriver(string name)
	{
		DeviceName = name;
	}

}
