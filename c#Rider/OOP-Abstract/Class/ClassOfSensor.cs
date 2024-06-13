using System.Security.Cryptography;
namespace Class
{
    public abstract class ClassOfSensor
    {
        // Instanz-Felder
        public string? SofManufacturer { get; set; }
        public string? SofSerialNumber { get; set; }
        public string? SofModel { get; set; }
        // public Guid ID { get; set; }
        public Guid SofID { get; }
        public abstract string Unit { get; }
        
        public double? MaxValue { get; protected set; }
        public double? MinValue { get; protected set; }
        

        
        
        
        // Methode besitzt keine Implementierung
        public abstract double MofMessure();                // Der Anweisungsblock muss vom Erben gefüllt werden

        protected virtual void MofCollectedFieldValues(List<(string Name, string Value)>fields)
        {
            // Implementierung der Methode
            fields.AddRange([
                (nameof(SofManufacturer), SofManufacturer),
                (nameof(SofSerialNumber), SofSerialNumber),
                (nameof(SofModel), SofModel),
                (nameof(SofID), SofID.ToString()),
            ]);
        }
        

        public abstract double Measure();
        public abstract void MofReset();
    }
}