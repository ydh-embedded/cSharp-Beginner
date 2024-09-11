namespace _05._4_Array_Math;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine(@"
        
        The Pow in this code is making the first element of the reversed array, which is 8, raised to the power of 2.

Here's a step-by-step breakdown:

The array arr is initialized with the elements {8, 5, 4}.
The Array.Reverse method is called on arr, which reverses the order of the elements in the array. So, arr becomes {4, 5, 8}.
The first element of the reversed array, arr[0], is 4.
The Math.Pow method is called with arr[0] as the base and 2 as the exponent. This raises 4 to the power of 2, resulting in 16.
So, the Pow is making 4 squared, which is 16.");
        
        int[] arr = {8, 5, 4};
        Array.Reverse(arr);
        double x = Math.Pow(arr[0], 2);
    }
}
