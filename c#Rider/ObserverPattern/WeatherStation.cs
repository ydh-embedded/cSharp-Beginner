namespace ObserverPattern;

class WeatherStation : IObservable
{
	private static readonly Random randomizer = new();
	private List<IObserver> observers;

	public string Name { get; }
	public string Location { get; private set; }
	public double LastTemperature { get; private set; }

	public void AddObserver(IObserver observer)
	{
		// Merke dir den Beobachter.
		observers.Add(observer);
	}

	public void RemoveObserver(IObserver observer)
	{
		// Entferne den Beobachter, sofern vorhanden.
		observers.Remove(observer);
	}

	public double Measure()
	{
		double oldTemperature = LastTemperature;
		LastTemperature = randomizer.Next(-20, 40);
		Console.WriteLine($"[{Name}]: Messwert erfassen...{LastTemperature:N2}");
		// Benachrichtige alle Observer über die Zustandsänderung
		if (oldTemperature != LastTemperature)
		{
			foreach (IObserver observer in observers)
			{
				observer.Update(this);
			}
		}
		return LastTemperature;
	}

	public WeatherStation(string name, string location)
	{
		observers = [];
		Name = name;
		Location = location;
	}
}
