namespace AbstractClasses;

class HumiditySensor : Sensor
{
	public override string SofUnit => "%";
	
	// Konstruktor vom Feuchtigkeit-Sensor
	public HumiditySensor(string sOfManufacturer, string sOfModel, string sOfSerialNumber)
		: base(sOfManufacturer, sOfModel, sOfSerialNumber){}
	
	// Methode der aktuellen Temperatur
	protected override double MtoMeasureCurrentValue()
	{
		// Wir erzeugen eine Random Zahl, um Temperaturen zu simulieren
		Random random = new();
		
		// wir erzeugen eine lokale variable 
		double dOfHumidity = random.NextDouble() * 100;
		
		// Wir geben den Wert mit der Einheit {SofUnit} zurück
		Console.WriteLine($"Messe relative Luftfeuchte...{dOfHumidity:N2}{SofUnit}");
		return dOfHumidity;
	}
}
