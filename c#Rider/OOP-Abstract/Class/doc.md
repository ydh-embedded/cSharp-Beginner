# abstract

## Class

-   Der Anweisungsblock muss vom Erben gefüllt werden
  - Methode besitzt keine Implementierung

````csharp

namespace Class;

internal abstract class ClassOfSensor
{
    // Instanz-Felder
    public string SofManufacturer { get; set; }
    public string SofSerialNumber { get; set; }
    public string SofModel { get; set; }
    public Guid ID { get; set; }
    
    
    // Methode besitzt keine Implementierung
    public abstract double MofMessure();                    
}
````  

## class

-   von einer abstracten classe können keine Objecte erzeugt werden
  - abstracte classen können aber Konstructoren enthalten
  - Yes, this is a correct example of an abstract class in C#.
  - Here are some key points that make it an abstract class:

The abstract keyword is used to declare the class as abstract.
The class contains a property with no implementation (MofMessure()). This property is declared as abstract and must be implemented by any non-abstract derived classes.
The class also contains a protected method (MofCollectedFieldValues()) that can be used by derived classes.




## implemented Method

- In this corrected version, the MofMessure() method is implemented
- in the ClassOfTempSensor class, and it returns a temperature value in degrees Celsius.
  - Note that you can replace the return value with the actual temperature measurement
  obtained from the temperature sensor.
  
````csharp

namespace Class
{
    public class ClassOfTempSensor : ClassOfSensor
    {
        // public override string Unit => throw new NotImplementedException();
        public override string Unit => "°C";

        public override double Measure()
        {
            // Implementation of the Measure method
            throw new NotImplementedException();
        }

        public override void MofReset()
        {
            // Implementation of the MofReset method
            throw new NotImplementedException();
        }

        public override double MofMessure()
        {
            // Implementation of the MofMessure method
            // For example, you can return the temperature in degrees Celsius
            return 25.0;
        }
    }
}

````