using System;
using System.Linq;

namespace Arrays_in_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("  Loop  ");
            Console.WriteLine("**************************************************************************");

            int[] numbers = new int[10];
            for (int k = 0; k < 10; k++)
            {
                numbers[k] = k * 2;
            }

            // Print the array with a separator using the PrintArrayWithSeparator method
            PrintArrayWithSeparator(numbers, " | ");

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("  Foreach-Loop  ");
            Console.WriteLine("**************************************************************************");

            int[] numbers2 = new int[10];
            for (int k = 0; k < 10; k++)
            {
                numbers2[k] = k * 2;
            }
            // Print the array with a separator using the PrintArrayWithSeparator method
            PrintArrayWithSeparator(numbers2, " | ");
            
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("  Addition Loop  ");
            Console.WriteLine("**************************************************************************");

            int[] arr = { 11, 35, 62, 555, 989 };
            int sum = 0;
            foreach (int x in arr)
            {
                sum += x;
            }
            // Print the sum
            //PrintArrayWithSeparator(sum, " | ");
            Console.WriteLine(sum);

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("  die Foreach Schleife  ");
            Console.WriteLine("**************************************************************************");

            int[] items = { 0, 5, 3, 2, 1 };
            // Print the array with a separator using the PrintArrayWithSeparator method
            PrintArrayWithSeparator(items, " | ");

        }

        /// <summary>
        /// Prints an array to the console, one element per line.
        /// </summary>
        /// <param name="array">The array to print.</param>
        static void PrintArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Prints an array to the console, with a separator between elements.
        /// </summary>
        /// <param name="array">The array to print.</param>
        /// <param name="separator">The separator to use between elements.</param>
        static void PrintArrayWithSeparator(int[] array, string separator)
        {
            Console.WriteLine(string.Join(separator, array));
            Console.WriteLine("**************************************************************************");
        }
    }
}