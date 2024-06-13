using NUnit.Framework;
namespace Nunit_Calculator;


public class T000_Calculator
{
    // [Fact]
    public void AddTest()
    {
        var calculator = new Calculator();
        var result = calculator.Add(2,3);
        Assert.Equals(5, result);
    }


    // [Fact]
    public void Add_TwoNumbers_ReturnsSum()
    {
        // Arrange
        var calculator = new Calculator();
        var a = 2;
        var r = 3;

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
        _value = 0;
    }

    public Calculator(int value)
    {
        _value = value;
    }

    public Calculator Add(int a, int b)
    {
        _value = a + b;
        return this;
    }

    public int Value { get { return _value; } }
}