using nUnit_Guterbahnhof;

namespace nUnit_Guterbahnhof;

class Gueterzug : Zug
{
	public override void AddWaggon(Waggon waggon)
	{
		if (this.anzahlWaggons > 0)
		{
			// Alle weiteren Waggons müssen dasselbe Ziel wie der Zug haben.
			if (waggon.GetZiel() != this.GetZiel())
			{
				throw new InvalidOperationException("Ziel des Waggons entspricht nicht Ziel des Zugs");
			}
			else
			{
				// Neuen Waggon an Wagenreihung anhängen.
				this.wagenreihung = [.. wagenreihung, waggon];
			}
		}
		else
		{
			// Erster Waggon bestimmt Ziel des Zugs.
			this.wagenreihung = [waggon];
			this.SetZiel(waggon.GetZiel());
		}

		// Durch die Änderung des Arrays muss auch das Feld
		// anzahlWaggons aktualisiert werden.
		this.anzahlWaggons = this.wagenreihung.Length;
	}


}