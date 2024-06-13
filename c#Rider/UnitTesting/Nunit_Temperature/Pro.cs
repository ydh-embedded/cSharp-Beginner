namespace Xunit;

public class Pro
{

    static void Main(string[] args)
    {
        Temperature(20,'\u00b0C');
    }
    
    
    
    
    
    public Temperature Convert(Temperature from, TemperatureUnit to)
    {
        if (from.Unit == TemperatureUnit.Celcius && to == TemperatureUnit.Fahrenheit)
        {
            return new Temperature((9.0 / 5.0) * from.Value + 32, to);
        }

        if (from.Unit == TemperatureUnit.Fahrenheit && to == TemperatureUnit.Celcius)
        {
            return new Temperature((5.0 / 9.0) * (@from.Value - 32), to);
        }

        return from;
    }

    public class TemperatureUnit
    {
        public static TemperatureUnit Celcius { get; set; }
        public static TemperatureUnit Fahrenheit { get; set; }
    }

    public class Temperature(double value, TemperatureUnit unit)
    {
        public TemperatureUnit Unit { get; } = unit;
        public double Value { get; } = value;

        public class TemperatureMember
        {
        }
    }
    

    
    
    
    
}