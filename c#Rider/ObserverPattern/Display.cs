namespace ObserverPattern;

class Display : IObserver
{
	public string Name { get; }
	public ConsoleColor Color { get; }

	// Diese Methode wird vom Observable Objekt aufgerufen,
	// wenn es seinen Zustand geändert hat.
	public void Update(IObservable observable)
	{
		if (observable is WeatherStation station)
		{
			Console.ForegroundColor = Color;
			Console.WriteLine($"[{Name}] Aktuelle Temperatur ist: {station.LastTemperature:N2}");
			Console.ResetColor();
		}
	}

	public Display(string name, ConsoleColor color)
	{
		Name = name;
		Color = color;
	}
}