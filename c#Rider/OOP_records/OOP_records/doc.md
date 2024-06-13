# 🐳 records

In C# 9 and later, the record keyword is used to create a reference type that provides a simple way to create immutable objects.

When you declare a record class like public record class TestData(double Salary, double HealthInsuranceRate, int TaxCategory, double FreeTaxAmount, double NetSalary);, the compiler generates a class with the following characteristics:

## 🐬 1. Immutability:
-   The properties of the record class are immutable by default, meaning their values cannot be changed after the object is created.

## 🐬 2. Value-based equality:
-   Records have value-based equality, which means that two records are considered equal if all their properties have the same values.

## 🐬 3. ToString() method:
-   The compiler generates a ToString() method that returns a string representation of the record, including the values of all its properties.

## 🐬 4. Equality members:
-   The compiler generates Equals() and GetHashCode() methods that implement value-based equality.

## 🐬 5. Copy constructor:
-   The compiler generates a copy constructor that allows you to create a copy of a record.

## 🐬 6. Deconstructor:
-   The compiler generates a deconstructor that allows you to deconstruct a record into its individual properties.

## [public class TestData : IEquatable<TestData>](record)

`````csharp
public class TestData : IEquatable<TestData>
{
    public double Salary              { get; init; }
    public double HealthInsuranceRate { get; init; }
    public int    TaxCategory         { get; init; }
    public double FreeTaxAmount       { get; init; }
    public double NetSalary           { get; init; }

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
`````