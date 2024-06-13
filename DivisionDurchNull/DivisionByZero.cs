using System;

namespace DivisionByZero
{
    class Program
    {
        static void Main(string[] args)
        {
            // Check if the user has provided exactly two arguments
            if (args.Length != 2)
            {
                Console.WriteLine("Please provide exactly two integer arguments.");
                return;
            }

            // Parse the given arguments as integers
            int firstNumber;
            int secondNumber;
            if (!int.TryParse(args[0], out firstNumber) || !int.TryParse(args[1], out secondNumber))
            {
                Console.WriteLine("One or both of the provided arguments are not valid integers.");
                return;
            }

            // Check if the second number is not zero
            if (secondNumber == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                return;
            }

            // Perform the division and output the result
            double result = firstNumber / (double)secondNumber;
            Console.WriteLine($"Division of {firstNumber} and {secondNumber} is {result}");
        }
    }
}