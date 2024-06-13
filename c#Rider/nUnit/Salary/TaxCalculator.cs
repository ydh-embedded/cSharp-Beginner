using System;

namespace TaxCalculator
{
    public enum TaxType
    {
        HealthInsurance,
        PublicPension,
        UnemploymentInsurance,
        IncomeTax,
        SolidaritySurcharge,
        ChurchTax
    }

    public class TaxInput
    {
        public decimal GrossIncome               { get; set; }
        public decimal HealthInsuranceCosts      { get; set; }
        public decimal PublicPensionRate         { get; set; }
        public decimal UnemploymentInsuranceRate { get; set; }
        public decimal IncomeTaxRate             { get; set; }
        public decimal ChurchTaxRate             { get; set; }
        public TaxType TaxType                   { get; set; }
    }

    public class TaxCalculator
    {
        public decimal CalculateHealthInsurance(decimal healthInsuranceCosts)
        {
            // calculate health insurance costs
            return healthInsuranceCosts;
        }

        public decimal CalculatePublicPension(decimal publicPensionRate, decimal grossIncome)
        {
            // calculate public pension insurance costs
            return publicPensionRate * grossIncome;
        }

        public decimal CalculateUnemploymentInsurance(decimal unemploymentInsuranceRate, decimal grossIncome)
        {
            // calculate unemployment insurance costs
            return unemploymentInsuranceRate * grossIncome;
        }

        public decimal CalculateIncomeTax(decimal incomeTaxRate, decimal grossIncome)
        {
            // calculate income tax
            return incomeTaxRate * grossIncome;
        }

        public decimal CalculateSolidaritySurcharge(decimal incomeTaxRate, decimal grossIncome)
        {
            // calculate solidarity surcharge
            return incomeTaxRate * grossIncome * 0.05m;
        }

        public decimal CalculateChurchTax(decimal churchTaxRate, decimal grossIncome)
        {
            // calculate church tax
            return churchTaxRate * grossIncome * 0.08m;
        }

        public decimal CalculateTax(TaxInput input)
        {
            decimal tax = 0;

            switch (input.TaxType)
            {
                case TaxType.HealthInsurance:
                    tax = CalculateHealthInsurance(input.HealthInsuranceCosts);
                    break;
                case TaxType.PublicPension:
                    tax = CalculatePublicPension(input.PublicPensionRate, input.GrossIncome);
                    break;
                case TaxType.UnemploymentInsurance:
                    tax = CalculateUnemploymentInsurance(input.UnemploymentInsuranceRate, input.GrossIncome);
                    break;
                case TaxType.IncomeTax:
                    tax = CalculateIncomeTax(input.IncomeTaxRate, input.GrossIncome);
                    break;
                case TaxType.SolidaritySurcharge:
                    tax = CalculateSolidaritySurcharge(input.IncomeTaxRate, input.GrossIncome);
                    break;
                case TaxType.ChurchTax:
                    tax = CalculateChurchTax(input.ChurchTaxRate, input.GrossIncome);
                    break;
                default:
                    throw new ArgumentException("Invalid tax type");
            }

            return tax;
        }
    }

    class Program          // Um die Test-Methoden nutzen zu können ist das Programm auskommentiert. 
    {
        // static void Main(string[] args)
        // {
        //     Console.Write("Enter your gross income: ");
        //     decimal grossIncome = Convert.ToDecimal(Console.ReadLine());
        //
        //     Console.Write("Enter your health insurance costs: ");
        //     decimal healthInsuranceCosts = Convert.ToDecimal(Console.ReadLine());
        //
        //     Console.Write("Enter your public pension rate: ");
        //     decimal publicPensionRate = Convert.ToDecimal(Console.ReadLine());
        //
        //     Console.Write("Enter your unemployment insurance rate: ");
        //     decimal unemploymentInsuranceRate = Convert.ToDecimal(Console.ReadLine());
        //
        //     Console.Write("Enter your income tax rate: ");
        //     decimal incomeTaxRate = Convert.ToDecimal(Console.ReadLine());
        //
        //     Console.Write("Enter your church tax rate: ");
        //     decimal churchTaxRate = Convert.ToDecimal(Console.ReadLine());
        //
        //     Console.Write("Enter the tax type (1=HealthInsurance, 2=PublicPension, 3=UnemploymentInsurance, 4=IncomeTax, 5=SolidaritySurcharge, 6=ChurchTax): ");
        //     int taxType = Convert.ToInt32(Console.ReadLine());
        //
        //     TaxType taxTypeEnum = (TaxType)taxType;
        //
        //     TaxInput input = new TaxInput
        //     {
        //         GrossIncome = grossIncome,
        //         HealthInsuranceCosts = healthInsuranceCosts,
        //         PublicPensionRate = publicPensionRate,
        //         UnemploymentInsuranceRate = unemploymentInsuranceRate,
        //         IncomeTaxRate = incomeTaxRate,
        //         ChurchTaxRate = churchTaxRate,
        //         TaxType = taxTypeEnum
        //     };
        //
        //     TaxCalculator calculator = new TaxCalculator();
        //
        //     decimal tax = calculator.CalculateTax(input);
        //
        //     Console.WriteLine($"Your tax is: {tax}");
        // }
    }
    
    
    
}