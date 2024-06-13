namespace Güterbahnhof;

class Program
{
	static void Main(string[] args)
	{
		TestGleis();
	}

	private static void TestWaggon()
	{
		Gueterwaggon waggonA = new("Erfurt", 2);
		Gueterwaggon waggonB = new("Erfurt", 3);
		Gueterwaggon waggonC = new("Leipzig", 1);

		Gueterzug zug = new();
		Console.WriteLine($"Ziel: {zug.GetZiel()} Länge: {zug.GetWagenreihung().Length}");
		zug.AddWaggon(waggonA);
		Console.WriteLine($"Ziel: {zug.GetZiel()} Länge: {zug.GetWagenreihung().Length}");
		zug.AddWaggon(waggonB);
		Console.WriteLine($"Ziel: {zug.GetZiel()} Länge: {zug.GetWagenreihung().Length}");
		// Hier müsste eine Exception auftreten, da der Waggon
		// ein anderes Ziel als der Zug hat.
		zug.AddWaggon(waggonC);
	}

	private static void TestGleis()
	{
		Gueterzug zug = new();
		zug.AddWaggon(new Gueterwaggon("Erfurt", 2));
		Gueterzug zug2 = new();
		zug2.AddWaggon(new Gueterwaggon("Leipzig", 3));

		Listenanzeige anzeige = new();

		Rangiergleis gleis10 = new(10);
		Rangiergleis gleis8 = new(8);
		// Anzeige registriert sich bei Gleisen.
		anzeige.neuesGleis(gleis10);
		anzeige.neuesGleis(gleis8);
		// Durch Ändern der Zugbelegung informiert das Gleis
		// die Anzeige.
		Console.WriteLine("ℹ Gleis 10 wird mit Zug begelegt ℹ");
		gleis10.SetZugbelegung(zug);
		Console.WriteLine("ℹ Gleis 8 wird mit Zug begelegt ℹ");
		gleis8.SetZugbelegung(zug2);

	}
}
