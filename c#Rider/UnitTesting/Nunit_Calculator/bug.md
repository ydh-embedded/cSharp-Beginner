````csharp Pro.cs

namespace Nunit_Calculator;

public class Pro
{
        public Calculator Add(int a, int b)
        {
            return new Calculator(a + b);
        }
}

````

````csharp T000_Calculator.cs

using NUnit.Framework;
namespace Nunit_Calculator;


public class T000_Calculator
{
    // [Fact]
    public void AddTest()
    {
        var calculator = new Calculator();
        var result = calculator.Add();
        Assert.Equals(5, result);
    }


    // [Fact]
    public void Add_TwoNumbers_ReturnsSum()
    {
        // Arrange
        var calculator = new Calculator();
        var a = 2;
        var b = 3;

        // Act
        var result = calculator.Add(a, b);

        // Assert
        Assert.Equals(5, result);
    }
}

public class Calculator
{
    public Calculator(int i)
    {
        throw new NotImplementedException();
    }

    public Calculator Add(int i, int i1)
    {
        throw new NotImplementedException();
    }
}
````