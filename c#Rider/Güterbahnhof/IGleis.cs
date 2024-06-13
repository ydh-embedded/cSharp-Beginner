namespace Güterbahnhof;

interface IGleis
{
	void RegistriereAnzeige(IAnzeige anzeige);
	void EntferneAnzeige(IAnzeige anzeige);
	public int GleisNr { get; }
}
