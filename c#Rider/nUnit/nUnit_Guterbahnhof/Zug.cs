using nUnit_Guterbahnhof;

namespace nUnit_Guterbahnhof;

abstract class Zug
{
	protected Waggon[] wagenreihung;
	protected string ziel;
	protected int anzahlWaggons;

	public abstract void AddWaggon(Waggon waggon);

	public Waggon[] GetWagenreihung() => this.wagenreihung;

	public void SetZiel(string ziel) => this.ziel = ziel;

	public string GetZiel() => this.ziel;

	public Zug()
	{
		this.ziel = "N/A";
		this.wagenreihung = [];
		this.anzahlWaggons = wagenreihung.Length;
	}
}
