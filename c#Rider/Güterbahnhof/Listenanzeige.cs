namespace Güterbahnhof;

class Listenanzeige : IAnzeige
{
	private List<IGleis> beobachtung;

	public void Aktualisieren()
	{
		Console.WriteLine("🚊 Aktuelle Informationen zu den Gleisbelegungen:");
		foreach (IGleis gleis in beobachtung)
		{
			if (gleis is Rangiergleis rangiergleis)
			{
				bool istBelegt = rangiergleis.GetZugbelegung() is not null;
				string ziel = rangiergleis.GetZugbelegung()?.GetZiel() ?? "Unbekannt";
				string meldung = $"Gleis: {rangiergleis.GetGleisNr():D2}";
				meldung += " " + (istBelegt ? $"Ziel: {ziel}" : $"Derzeit nicht belegt");
				Console.WriteLine(meldung);
			}
			else
			{
				Console.WriteLine($"Gleis: {gleis.GleisNr:D2} (Keine weiteren Informationen verfügbar)");
			}
		}
	}

	public void neuesGleis(IGleis gleis)
	{
		beobachtung.Add(gleis);
		gleis.RegistriereAnzeige(this);
	}

	public Listenanzeige()
	{
		beobachtung = [];
	}
}
