namespace ObserverPattern;

class Program
{
	static void Main(string[] args)
	{
		WeatherStation erfurt = new("Erfurt-001", "Erfurt");
		WeatherStation leipzig = new("Leipzig-005", "Leipzig");
		Display display1 = new("D-001", ConsoleColor.Red);
		Display display2 = new("D-002", ConsoleColor.Green);
		Display display3 = new("D-003", ConsoleColor.Yellow);

		// display1 beobachtet WetterStation Erfurt und Leipzig
		erfurt.AddObserver(display1);
		leipzig.AddObserver(display1);

		erfurt.AddObserver(display2);
		leipzig.AddObserver(display3);

		erfurt.Measure();
		leipzig.Measure();
		erfurt.Measure();

		erfurt.RemoveObserver(display1);
		erfurt.Measure();

	}
}
