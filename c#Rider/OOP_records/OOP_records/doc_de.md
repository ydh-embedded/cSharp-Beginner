# 🐳 records

In C# 9 und höher wird das Schlüsselwort record verwendet, um einen Referenztyp zu erstellen, der eine einfache Möglichkeit bietet, unveränderliche Objekte zu erstellen.

Wenn Sie eine Record-Klasse wie public record class TestData(double Salary, double HealthInsuranceRate, int TaxCategory, double FreeTaxAmount, double NetSalary); deklarieren, erzeugt der Compiler eine Klasse mit den folgenden Eigenschaften:

## 🐬 1. Unveränderlichkeit:
- Die Eigenschaften der Record-Klasse sind standardmäßig unveränderlich, d. h. ihre Werte können nach der Erstellung des Objekts nicht mehr geändert werden.

## 🐬 2. Wertbasierte Gleichheit:
- Datensätze haben eine wertbasierte Gleichheit, was bedeutet, dass zwei Datensätze als gleich angesehen werden, wenn alle ihre Eigenschaften die gleichen Werte haben.
- können aber in zwei verschiedenen Feldern liegen (unterschiedliche Objekte)

## 🐬 3. ToString()-Methode:
- Der Compiler erzeugt eine ToString()-Methode, die eine String-Darstellung des Datensatzes einschließlich der Werte aller seiner Eigenschaften zurückgibt.

## 🐬 4. Gleichheitsmitglieder:
- Der Compiler erzeugt die Methoden Equals() und GetHashCode(), die eine wertbasierte Gleichheit implementieren.

## 🐬 5. Kopier-Konstruktor:
- Der Compiler generiert einen Kopierkonstruktor, mit dem Sie eine Kopie eines Datensatzes erstellen können.

## 🐬 6. Dekonstrukteur:
- Der Compiler generiert einen Dekonstruktor, mit dem ein Datensatz in seine einzelnen Eigenschaften zerlegt werden kann.


Übersetzt mit DeepL.com (kostenlose Version)
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
        this.Salary              = Salary;
        this.HealthInsuranceRate = HealthInsuranceRate;
        this.TaxCategory         = TaxCategory;
        this.FreeTaxAmount       = FreeTaxAmount;
        this.NetSalary           = NetSalary;
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
               Salary              == other.Salary &&
               HealthInsuranceRate == other.HealthInsuranceRate &&
               TaxCategory         == other.TaxCategory &&
               FreeTaxAmount       == other.FreeTaxAmount &&
               NetSalary           == other.NetSalary;
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