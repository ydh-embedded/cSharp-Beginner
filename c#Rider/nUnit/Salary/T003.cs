using TaxCalculator;

using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Salary
{
    /// <summary>
    /// Tests for unemployment insurance calculator.
    /// </summary>
    /// <remarks>
    /// This class contains unit tests for the unemployment insurance calculator.
    /// </remarks>
    [TestFixture]
    public class UnemploymentInsuranceCalculatorTests // Renamed from T003
    {
        /// <summary>
        /// Tests the calculation of unemployment insurance with positive values.
        /// </summary>
        /// <remarks>
        /// This test method creates a <see cref="TaxInput"/> object with positive values for gross income and unemployment insurance rate,
        /// and then calls the <see cref="TaxCalculator.CalculateTax"/> method with that object.
        /// The expected result is the product of the input gross income and unemployment insurance rate.
        /// </remarks>
        [Test]
        public void CalculateUnemploymentInsurance_PositiveValues()
        {
            // Arrange
            var input = CreateTaxInputWithPositiveValues();

            // Act
            var calculator = new TaxCalculator.TaxCalculator();
            var tax = calculator.CalculateTax(input);

            // Assert
            ClassicAssert.AreEqual(150, tax);
        }

        /// <summary>
        /// Creates a <see cref="TaxInput"/> object with positive values for testing.
        /// </summary>
        /// <returns>A <see cref="TaxInput"/> object with positive values.</returns>
        private TaxInput CreateTaxInputWithPositiveValues()
        {
            return new TaxInput
            {
                GrossIncome = 5000,
                HealthInsuranceCosts = 0,
                PublicPensionRate = 0,
                UnemploymentInsuranceRate = 0.03m,
                IncomeTaxRate = 0,
                ChurchTaxRate = 0,
                TaxType = TaxType.UnemploymentInsurance
            };
        }
    }
}