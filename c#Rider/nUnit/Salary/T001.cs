using TaxCalculator;
using NUnit.Framework;
using NUnit.Framework.Legacy;

namespace SalaryCalculator
{
    /// <summary>
    /// Tests for health insurance calculator.
    /// </summary>
    /// <remarks>
    /// This class contains unit tests for the health insurance calculator.
    /// </remarks>
    
    
    
    [TestFixture]
    public class HealthInsuranceCalculatorTests
    {
       
        
        /// <summary>
        /// Tests the calculation of health insurance with positive values.
        /// </summary>
        /// <remarks>
        /// This test method creates a <see cref="TaxInput"/> object with positive values for gross income and health insurance costs,
        /// and then calls the <see cref="TaxCalculator.CalculateTax"/> method with that object.
        /// The expected result is the same as the input health insurance costs.
        /// </remarks>
        
        
        
        [Test]
        public void CalculateHealthInsurance_PositiveValues()
        {
            // Arrange
            var input = CreateTaxInputWithPositiveValues();

            // Act
            TaxCalculator.TaxCalculator calculator = new TaxCalculator.TaxCalculator();                 // var calculator = new TaxCalculator();
            var tax = calculator.CalculateTax(input);

            // Assert
            ClassicAssert.AreEqual(1000, tax);
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
                HealthInsuranceCosts = 1000,
                PublicPensionRate = 0,
                UnemploymentInsuranceRate = 0,
                IncomeTaxRate = 0,
                ChurchTaxRate = 0,
                TaxType = TaxType.HealthInsurance
            };
        }
    }
}