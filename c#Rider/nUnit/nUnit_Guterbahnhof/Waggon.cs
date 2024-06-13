using nUnit_Guterbahnhof;

namespace nUnit_Guterbahnhof;

public abstract class Waggon
{
	protected string ziel;

	public string GetZiel() => this.ziel;

	public Waggon(string ziel)
	{
		this.ziel = ziel;
	}

	private Waggon(  )
	{
		throw new NotImplementedException();
	}

	// internal static Waggon Instance { get; } = new Waggon();
}
