using TaxCalculator;

using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Salary
{
    /// <summary>
    /// Tests for public pension calculator.
    /// </summary>
    /// <remarks>
    /// This class contains unit tests for the public pension calculator.
    /// </remarks>
    [TestFixture]
    public class PublicPensionCalculatorTests // Renamed from T002
    {
        /// <summary>
        /// Tests the calculation of public pension with positive values.
        /// </summary>
        /// <remarks>
        /// This test method creates a <see cref="TaxInput"/> object with positive values for gross income and public pension rate,
        /// and then calls the <see cref="TaxCalculator.CalculateTax"/> method with that object.
        /// The expected result is the product of the input gross income and public pension rate.
        /// </remarks>
        [Test]
        public void CalculatePublicPension_PositiveValues()
        {
            // Arrange
            var input = CreateTaxInputWithPositiveValues();

            // Act
            var calculator = new TaxCalculator.TaxCalculator();
            var tax = calculator.CalculateTax(input);

            // Assert
            ClassicAssert.AreEqual(750, tax);
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
                PublicPensionRate = 0.15m,
                UnemploymentInsuranceRate = 0,
                IncomeTaxRate = 0,
                ChurchTaxRate = 0,
                TaxType = TaxType.PublicPension
            };
        }
    }
}