namespace Interfaces;

class Application
{
	private IPrinterDriver printerDriver;

	public void Run()
	{
		LaserLexmarkDriver lexmark = new("test");

		// printerDriver.GetDiagnosticData(); // Nicht sichtbar, da protected im Interface.
		lexmark.GetDiagnosticData(); // OK: Da GetDiagnosticData als public implementiert in Klasse.
																 //lexmark.PrintTestPage(); // Fehler: PrintTestPage ist per Default im Interface definiert und damit explizit in Klasse.


		Console.WriteLine($"Application wants to print with printer {printerDriver.DeviceName}.");
		bool testPageSuccessfullyPrinted = printerDriver.PrintTestPage();
		if (testPageSuccessfullyPrinted)
		{
			ConsoleColor printColor = ConsoleColor.DarkCyan;
			if (printerDriver.SupportsColor)
			{
				printerDriver.PrintColoredText("Some application data", printColor);
			}
			else
			{
				printerDriver.PrintText("Some non-colored application data");
			}
		}

	}

	public Application(IPrinterDriver driver)
	{
		this.printerDriver = driver;
	}


}
