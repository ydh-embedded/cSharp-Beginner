namespace Interfaces;

class CoffeeMachine : ISaveable, IIdentifiable
{
	public void Save()
	{
		// Um auf ein explizit implementiertes Member zuzugreifen, müssen
		// wir das Objekt in die entsprechende Schnittstelle konvertieren.
		ISaveable saveable = this;
		Console.WriteLine($"Speichere Zustand dieses Objekts. ID = {saveable.ID}");
	}

	// Explizite Implementierungen von Schnittstellen-Member:
	// Durch diese ist es möglich, Namenskonflikte aufzulösen, die durch Mehrfachvererbung
	// von Schnittstellen entstehen. Die Sichtbarket wird weggelassen.
	string ISaveable.ID => saveId; // { get { return this.saveId; } }
	private string saveId;

	int IIdentifiable.ID => this.id;
	private int id;

	public CoffeeMachine(string saveId, int id)
	{
		this.saveId = saveId;
		this.id = id;
	}
}
