namespace OOP_records;

public class Pro
{
    public class TestData : IEquatable<TestData>
{
    public double Salary         { get; init; }
    public double HealthInsuranceRate { get; init; }
    public int    TaxCategory    { get; init; }
    public double FreeTaxAmount  { get; init; }
    public double NetSalary      { get; init; }

    public TestData(double Salary, double HealthInsuranceRate, int TaxCategory, double FreeTaxAmount, double NetSalary)
    {
        this.Salary = Salary;
        this.HealthInsuranceRate = HealthInsuranceRate;
        this.TaxCategory = TaxCategory;
        this.FreeTaxAmount = FreeTaxAmount;
        this.NetSalary = NetSalary;
    }

    public override string ToString()
    {
        return $"TestData {{ Salary = {Salary}, HealthInsuranceRate = {HealthInsuranceRate}, TaxCategory = {TaxCategory}, FreeTaxAmount = {FreeTaxAmount}, NetSalary = {NetSalary} }}";
    }

    public override bool Equals(object obj)
    {
        return Equals(obj as TestData);
    }

    public bool Equals(TestData other)
    {
        return other!= null &&
               Salary == other.Salary &&
               HealthInsuranceRate == other.HealthInsuranceRate &&
               TaxCategory == other.TaxCategory &&
               FreeTaxAmount == other.FreeTaxAmount &&
               NetSalary == other.NetSalary;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Salary, HealthInsuranceRate, TaxCategory, FreeTaxAmount, NetSalary);
    }

    public TestData With(double? Salary = null, double? HealthInsuranceRate = null, int? TaxCategory = null, double? FreeTaxAmount = null, double? NetSalary = null)
    {
        return new TestData(
            Salary?? this.Salary,
            HealthInsuranceRate?? this.HealthInsuranceRate,
            TaxCategory?? this.TaxCategory,
            FreeTaxAmount?? this.FreeTaxAmount,
            NetSalary?? this.NetSalary);
    }

    public void Deconstruct(out double Salary, out double HealthInsuranceRate, out int TaxCategory, out double FreeTaxAmount, out double NetSalary)
    {
        Salary = this.Salary;
        HealthInsuranceRate = this.HealthInsuranceRate;
        TaxCategory = this.TaxCategory;
        FreeTaxAmount = this.FreeTaxAmount;
        NetSalary = this.NetSalary;
    }
}
}