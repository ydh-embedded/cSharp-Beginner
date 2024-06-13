namespace AbstractClasses;

class Program
{
	static void Main(string[] args)
	{
		// TofTemperatur ist hier ein Tupel  t = tupel of
		TemperatureSensor tOfTempSensorV1 = new("Siemens", "ST001", "ST001-123456");
		TemperatureSensor tOfTempSensorV2 = new("Bosch", "BTA", "BTA-1234");
		
		
		Console.WriteLine(tOfTempSensorV1);
		Console.WriteLine(tOfTempSensorV2);
		tOfTempSensorV1.Measure();
		tOfTempSensorV2.Measure();
		
		Console.WriteLine(tOfTempSensorV1);
		Console.WriteLine(tOfTempSensorV2);
		tOfTempSensorV1.Measure();
		tOfTempSensorV2.Measure();
		
		Console.WriteLine(tOfTempSensorV1);
		Console.WriteLine(tOfTempSensorV2);
		
		tOfTempSensorV2.Reset();
		Console.WriteLine(tOfTempSensorV1);
		Console.WriteLine(tOfTempSensorV2);

		HumiditySensor tOfHumiditySensorV01 = new("Siemens", "SH707", "SH-707-123456");
		
		Console.WriteLine(tOfHumiditySensorV01);
		tOfHumiditySensorV01.Measure();
		tOfHumiditySensorV01.Measure();
		
		
		
		
		
		HumiditySensor TofHumiditySensorV02 = new("Siemens", "SH307", "SH-307-asde56");
		
		Console.WriteLine(TofHumiditySensorV02);
		tOfHumiditySensorV01.Measure();
		tOfHumiditySensorV01.Measure();

		
		
		Console.WriteLine(tOfHumiditySensorV01);
		Console.WriteLine(  "" 
		                  + $"Min: {tOfHumiditySensorV01.MinValue}" 
		                  + $"Max: {tOfHumiditySensorV01.MaxValue}"
		                  + $"Last: {tOfHumiditySensorV01.LastValue}");
		
		tOfHumiditySensorV01.Reset();
		Console.WriteLine(tOfHumiditySensorV01);
		
		
		Console.WriteLine(TofHumiditySensorV02);
		Console.WriteLine(  "" 
		                  + $"Min: {TofHumiditySensorV02.MinValue}" 
		                  + $"Max: {TofHumiditySensorV02.MaxValue}"
		                  + $"Last: {TofHumiditySensorV02.LastValue}");
		
		tOfHumiditySensorV01.Reset();
		Console.WriteLine(TofHumiditySensorV02);
	}
}
