# abstract Constructor

- you can define an abstract class with an abstract constructor,
- which means that any derived classes must implement a constructor 
- that calls the abstract constructor of the base class. Here is an example:

````csharp

namespace Konstruktor
{
    public abstract class ClassofContructor
    {
        protected ClassofContructor(string manufacturer, string model, string serialNumber)
        {
            // Die classe GUID besitzt eine statische Methode NewGuid
            ID = Guid.NewGuid(); // Global Unique ID (immutable)
        }

        public Guid ID { get; }
    }

    public class TempSensor : ClassofContructor
    {
        public TempSensor(string manufacturer, string model, string serialNumber)
            : base(manufacturer, model, serialNumber)
        {
            // Implementation of the TempSensor constructor
        }

        // Other members of the TempSensor class
    }
}

````