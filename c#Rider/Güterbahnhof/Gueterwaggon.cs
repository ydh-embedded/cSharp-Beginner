namespace Güterbahnhof;

class Gueterwaggon : Waggon
{
	private int gefahrgutklasse;

	public int GetGefahrgutklasse() => this.gefahrgutklasse;

	public Gueterwaggon(string ziel, int gefahrgutklasse)
		: base(ziel)
	{
		this.gefahrgutklasse = gefahrgutklasse;
	}
}
