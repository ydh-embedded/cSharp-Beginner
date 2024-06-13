namespace AbstractClasses;

class TemperatureSensor : Sensor
{
	// Alle Objekte der Klasse sollen sich den randomNumberGenerator
	// teilen. Deshalb verwenden wir hier ein statisches Feld.
	private static readonly Random randomNumberGenerator = new Random();

	public override string SofUnit => "°C";

	protected override double MtoMeasureCurrentValue()
	{
		int value = randomNumberGenerator.Next(-20, 230);
		Console.WriteLine($"Ich messe die Temperatur... {value}{SofUnit}");
		return value;
	}

	public override void Reset()
	{
		base.Reset();
		Console.WriteLine("Setze Temperatursensor zurück...");
	}

	public TemperatureSensor(string sOfManufacturer, string sOfModel, string sOfSerialNumber)
		: base(sOfManufacturer, sOfModel, sOfSerialNumber)
	{

	}
}
