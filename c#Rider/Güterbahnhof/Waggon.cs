namespace Güterbahnhof;

abstract class Waggon
{
	protected string ziel;

	public string GetZiel() => this.ziel;

	public Waggon(string ziel)
	{
		this.ziel = ziel;
	}
}
