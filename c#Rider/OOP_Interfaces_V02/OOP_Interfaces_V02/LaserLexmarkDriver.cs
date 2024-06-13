namespace Interfaces;

class LaserLexmarkDriver : IPrinterDriver
{
	// Bemerkung: Die Schnittstelle definiert diese Methode
	// als protected. Die implementierende Klasse muss diese Methode
	// jedoch als public anbieten.
	public string GetDiagnosticData()
	{
		return "No diagnostics";
	}

	public string PrinterType => "Laser";

	// Das Interface schreibt nur vor, dass das folgende Property
	// lesbar sein muss. Es ist aber auch ok, wenn es zuweisbar ist.
	public bool SupportsDuplex { get; set; }

	public bool SupportsColor { get; set; }

	public int MaxDotsPerInch { get; private set; }

	public bool PrintColoredText(string text, ConsoleColor color)
	{
		if (!SupportsColor) throw new InvalidOperationException($"Printer {DeviceName} does not support color printing");
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

	public string DeviceName { get; }

	public LaserLexmarkDriver(string deviceName, bool supportsDuplex = false, bool supportsColor = false, int maxDpi = 600)
	{
		SupportsDuplex = supportsDuplex;
		SupportsColor = supportsColor;
		MaxDotsPerInch = maxDpi;
		DeviceName = deviceName;
	}
}
