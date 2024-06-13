using TaxCalculator;

using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Salary;
/*
 * Author:
 * Description:
 *   Äquivalenzklasse 6
 *
 * TestCalculateChurchTax_PositiveValues() - This test method would create a TaxInput object with positive values for gross income and church tax rate, and then call the CalculateTax method with that object. The expected result would be the product of the input gross income and church tax rate (0.08).
 *
 *
 * This test method creates a TaxInput object with positive values for gross income, income tax rate, and church tax rate, and then calls the CalculateTax method with that object. The expected result is the product of the input gross income, income tax rate, and church tax rate (which is typically 9%). The Assert.AreEqual() method is used to verify that the calculated tax is equal to the expected value.
 * 
 * 
 */
[TestFixture]
public class T006           // Test-Äquivalenzklasse 6
{
 [Test]
 public void TestCalculateChurchTax_PositiveValues()
 {
  // Arrange
  TaxInput input = new TaxInput
  {
   GrossIncome = 5000,
   HealthInsuranceCosts = 0,
   PublicPensionRate = 0,
   UnemploymentInsuranceRate = 0,
   IncomeTaxRate = 0.25m,
   ChurchTaxRate = 0.09m,
   TaxType = TaxType.ChurchTax
  };


  TaxCalculator.TaxCalculator calculator = new TaxCalculator.TaxCalculator();

  // Act
  decimal tax = calculator.CalculateTax(input);

  // Assert
  ClassicAssert.AreEqual(405, tax);
 }
}
