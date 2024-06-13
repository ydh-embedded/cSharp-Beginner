using TaxCalculator;

using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Salary;
/*
 * Author:
 * Description:
 *   Äquivalenzklasse 5
 * 
 * TestCalculateSolidaritySurcharge_PositiveValues() - This test method would create a TaxInput object with positive values for gross income and income tax rate, and then call the CalculateTax method with that object. The expected result would be the product of the input income tax and the solidarity surcharge rate (0.05).
 *
 * This test method creates a TaxInput object with positive values for gross income and income tax rate, and then calls the CalculateTax method with that object. The expected result is the product of the input gross income, income tax rate, and solidarity surcharge rate (which is typically 5.5%). The Assert.AreEqual() method is used to verify that the calculated tax is equal to the expected value.
 * 
 */
[TestFixture]
public class T005           // Test-Äquivalenzklasse 5
{
 [Test]
 public void TestCalculateSolidaritySurcharge_PositiveValues()
 {
  // Arrange
  TaxInput input = new TaxInput
  {
   GrossIncome = 5000,
   HealthInsuranceCosts = 0,
   PublicPensionRate = 0,
   UnemploymentInsuranceRate = 0,
   IncomeTaxRate = 0.25m,
   ChurchTaxRate = 0,
   TaxType = TaxType.SolidaritySurcharge
  };


  TaxCalculator.TaxCalculator calculator = new TaxCalculator.TaxCalculator();

  // Act
  decimal tax = calculator.CalculateTax(input);

  // Assert
  ClassicAssert.AreEqual(125, tax);
 }
}
