// using NUnit.Framework;
// using TaxCalculator;
// namespace Salary;
//
// [TestFixture]
// public class T008
// {
//     [Test]
//     public void CalculateSolidaritySurcharge_PositiveValues()
//     {
//         // Arrange
//         var grossIncome = 5000;
//         var incomeTaxRate = 0.25m;
//         var input = new TaxInput
//         {
//             GrossIncome = grossIncome,
//             HealthInsuranceCosts = 0,
//             PublicPensionRate = 0,
//             UnemploymentInsuranceRate = 0,
//             IncomeTaxRate = incomeTaxRate,
//             ChurchTaxRate = 0,
//             TaxType = TaxType.IncomeTax
//         };
//
//         TaxCalculator.TaxCalculator calculator = new TaxCalculator.TaxCalculator();
//
//         // Act
//         decimal incomeTax = calculator.CalculateTax(input);
//         input.TaxType = TaxType.S;
// }