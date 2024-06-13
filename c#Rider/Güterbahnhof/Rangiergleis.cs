namespace Güterbahnhof;

class Rangiergleis : IGleis
{
	// Beachte: Eine readonly Referenzvariable
	// kann nicht mehr auf ein anderes Objekt zeigen,
	// aber das referenzierte Objekt kann trotzdem
	// seinen Zustand ändern.
	private readonly List<IAnzeige> anzeigen;
	private int gleisNr;
	private Zug? zugbelegung;

	public void EntferneAnzeige(IAnzeige anzeige)
	{
		anzeigen.Remove(anzeige);
	}

	public void RegistriereAnzeige(IAnzeige anzeige)
	{
		anzeigen.Add(anzeige);
	}

	public int GetGleisNr() => this.gleisNr;

	public int GleisNr => this.gleisNr;

	public Zug? GetZugbelegung() => this.zugbelegung;

	public void SetZugbelegung(Zug zug)
	{
		this.zugbelegung = zug;
		//anzeigen.ForEach(a => a.Aktualisieren());
		foreach (IAnzeige anzeige in anzeigen)
		{
			anzeige.Aktualisieren();
		}
	}

	public Rangiergleis(int gleisNr)
	{
		this.gleisNr = gleisNr;
		anzeigen = [];
		zugbelegung = null;
	}


}
