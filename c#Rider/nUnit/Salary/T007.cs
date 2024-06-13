using TaxCalculator;

using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace Salary
{
    /// <summary>
    /// Tests for solidarity surcharge calculator.
    /// </summary>
    /// <remarks>
    /// This class contains unit tests for the solidarity surcharge calculator.
    /// </remarks>
    [TestFixture]
    public class SolidaritySurchargeCalculatorTests // Renamed from T005
    {
        /// <summary>
        /// Tests the calculation of solidarity surcharge with positive values.
        /// </summary>
        /// <remarks>
        /// This test method creates a <see cref="TaxInput"/> object with positive values for gross income and income tax rate,
        /// and then calls the <see cref="TaxCalculator.TaxCalculator.CalculateTax"/> method with that object.
        /// The expected result is the product of the input income tax and the solidarity surcharge rate (0.05).
        /// </remarks>
        [Test]
        public void CalculateSolidaritySurcharge_PositiveValues()
        {
            // Arrange
            var input = CreateTaxInputWithPositiveValues();

            // Act
            var calculator = new TaxCalculator.TaxCalculator();
            var tax = calculator.CalculateTax(input);

            // Assert
            ClassicAssert.AreEqual(125, tax);
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
                UnemploymentInsuranceRate = 0,
                IncomeTaxRate = 0.25m,
                ChurchTaxRate = 0,
                TaxType = TaxType.SolidaritySurcharge
            };
        }
    }
}