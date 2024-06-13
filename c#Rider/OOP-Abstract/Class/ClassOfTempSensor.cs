namespace Class
{
    public abstract class ClassOfTempSensor : ClassOfSensor
    {
        protected abstract double MeasureCurrentValue();
        private double? LastMeasuredValue { get; set; } // double? wird benötigt, um in Zeile21 zu prüfen, ob ein Wert drin ist null = o!
        
        public override string Unit => "°C";           // public override string Unit => throw new NotImplementedException();
        
        public override double Measure()
        {
            // Implementation of the Measure method
            LastMeasuredValue = MeasureCurrentValue();

            // return Anweisung standard:
            // return (double)LastMeasuredValue;
            
            // return Anweisung, falls LastMeasuredValue keinen Wert besitzt, wird 0 zurückgegeben
            return LastMeasuredValue ?? 0;
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