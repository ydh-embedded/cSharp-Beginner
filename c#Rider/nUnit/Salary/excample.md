

## Switch Anweisung mit Input vom Terminal

````csharp

namespace Salary;
using System;

public class Pro
{
    static void Main(string[] args)
    { 
        double dGrossIncome;
        Console.Write("Enter your gross income: ");
        string? input = Console.ReadLine();
        if (double.TryParse(input, out dGrossIncome))
        {
            Console.WriteLine("You entered: " + dGrossIncome);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
        double taxRate = 0;
        
        taxRate = dGrossIncome switch
                    {
                        <= 10000 => 0.10,
                        <= 20000 => 0.15,
                        <= 30000 => 0.20,
                        <= 40000 => 0.25,
                        _ => 0.30
                    };
                    double tax = dGrossIncome * taxRate;
                    Console.WriteLine("Tax: " + tax);
                    Console.ReadLine();
                    
    }
}


````