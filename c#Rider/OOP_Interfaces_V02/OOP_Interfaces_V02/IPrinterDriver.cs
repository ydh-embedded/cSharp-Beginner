namespace Interfaces;

// In UML kann ein Interface nur öffentliche abstrakte Methoden enthalten.
// In C# können Interfaces auch Instanz-Properties, Instanz-Methoden mit Default-Implementierung,
// abstrakte Instanz-Methoden, Events und Indexer enthalten.
// - Von Interfaces lassen sich keine Objekte erstellen.
// - Interfaces können von anderen Interfaces erben.
// - Eine Klasse kann beliebig viele Schnittstellen implementieren, aber nur von einer Klasse erben.
// - In Interfaces genannte Member sind automatisch public, können aber eingeschränkt werden.
// - Member, die eine default-Implementierung besitzen, müssen nicht in der implementierenden Klasse überschrieben werden.
//   Sie können es aber.
// - Interfaces dürfen keine Instanzfelder definieren! (im Gegensatz zu abstrakten Klassen)
// - Interfaces dürfen jedoch statische Felder definieren!
// - Seit C# 11 darf man auch sogenannte static abstract Methoden hinzufügen. Das wird
//   zum Beispiel benutzt, um implementierende Datentypen dazu zu zwingen, bestimmte Operatoren
//   zu überladen.
interface IPrinterDriver
{
	#region Instanz-Member
	string DeviceName { get; }
	// Eine implementierende Klasse muss ein Property namens PrinterType bereitstellen,
	// welches vom Typ string ist und mindestens lesbar ist.
	string PrinterType { get; }
	// bool SupportsDuplex { get; } = false; // Fehler: Würde Instanzfeld benötigen!
	bool SupportsDuplex { get; } // Mindestens lesbar
	bool SupportsColor { get; }
	int MaxDotsPerInch { get; }

	// Diese Methoden sind automatisch abstract und public.
	bool PrintText(string text);
	bool PrintColoredText(string text, ConsoleColor color);
	// Diese Methode ist automatisch abstract, aber protected.
	protected string GetDiagnosticData();

	// Eine zu implementierende Methode, die eine Default-Implementierung
	// bereitstellt. Sie macht Gebrauch von der Methode PrintText.
	bool PrintTestPage()
	{
		if (SupportsColor)
		{
			PrintColoredText("Das ist eine Testseite!", ConsoleColor.Red);
		}
		else
		{
			PrintText("Das ist eine Testseite!");
		}
		return true;
	}
	#endregion

	#region Statische Member
	public const int A4PaperWidth = 210;
	public const int A4PaperHeight = 297;
	private const double InchToCM = 2.54;

	public static double InchesToCentimeters(double inches)
	{
		return inches * InchToCM;
	}

	public static double CentimetersToInches(double centimeters)
	{
		return centimeters / InchToCM;
	}

	// Statische Methoden ohne Body nicht erlaubt.
	// public static double F();

	// Statische abstrakte Methoden sind erlaubt.
	// public static abstract void F();
	#endregion
}
