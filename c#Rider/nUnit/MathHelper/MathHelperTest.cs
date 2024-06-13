using System.ComponentModel.DataAnnotations;
using NUnit.Framework;
using NUnit.Framework.Legacy;
namespace MathHelper;

[TestFixture]
internal class MathHelperTest
{

    [Test]
    public void CalculateArea_ShouldReturnCorrectResults()
    {
        MathHelper vHelper = new();
        // ClassicAssert. AreEqual("10.0", vHelper.CalculateArea(5,2));                                          // Wir prüfen das Ergebnis erwarteter Wert 10 berechnet 10.0
        ClassicAssert.AreEqual(10.0, vHelper.CalculateArea(5,2) , delta: double.Epsilon);            // Um Rundungsfehler der Gleitkomma-Zahlen zu vermeiden, verwenden wir delta
    }
    
    [Test , Sequential]
    public void CalculateArea_ShouldReturnCorrectResults(       [AllowedValues(2   ,  5   , 10  )]   double width ,
                                                                [AllowedValues(1   ,  3   ,  6  )]   double height,
                                                                [AllowedValues(2.0 , 15.0 , 50.0)]   double area)

    {
        MathHelper vHelper = new MathHelper();
        ClassicAssert.AreEqual(area, vHelper.CalculateArea(width, height), delta: double.Epsilon);
    }
}