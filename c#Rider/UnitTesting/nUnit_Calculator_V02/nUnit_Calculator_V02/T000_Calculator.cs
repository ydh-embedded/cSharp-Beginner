
using NUnit.Framework;
namespace nUnit_Calculator_V02;


[TestFixture] // Attribut funktioniert nur mit dem nUnit Framework und einer classen Definition mit Rückgabewert

public class T000_Calculator
{
    // [Fact] Attribut funktioniert nur mit dem xUnit Framework
    
    [Test] // Attribut funktioniert nur mit dem nUnit Framework
    public void AddTest()
    {
        var calculator = new Calculator();
        var result = calculator.Add(2,3);

        Assert.ReferenceEquals(5, result);
    }


    [Test]
    public void Add_TwoNumbers_ReturnsSum()
    {
        // Arrange
        var calculator = new Calculator();
        var a = 2;
        var r = 5;

        // Act
        var result = calculator.Add(a, r);

        // Assert
        Assert.Equals(5, result);
    }
}

public class Calculator
{
    private int _value;

    public Calculator()
    {
        _value = 5;
    }

    public Calculator Add(int a, int b)
    {
        _value = a + b;
        return this;
    }

    public int Value { get { return _value; } }
}