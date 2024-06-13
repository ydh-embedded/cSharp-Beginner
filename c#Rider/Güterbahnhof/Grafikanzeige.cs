namespace Güterbahnhof;

class Grafikanzeige : IAnzeige
{
	private List<IGleis> beobachtung;

	public void Aktualisieren()
	{
		Console.WriteLine("Zeige Gleise grafisch an...");
	}

	public void neuesGleis(IGleis gleis)
	{
		beobachtung.Add(gleis);
		gleis.RegistriereAnzeige(this);
	}

	public Grafikanzeige()
	{
		beobachtung = [];
	}
}