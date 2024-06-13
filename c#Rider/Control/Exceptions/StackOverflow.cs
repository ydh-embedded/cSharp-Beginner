namespace Exceptions;

public class StackOverflow
{
     
    private const int _CounterMax = 7;
    private const int _OutputFrequency = 1; // Changed from 7 to 1
    static int _counter = 0;

    private static void PreventativeExample()
    {
        try
        {
            // Iterate counter.
            _counter++;
            // Output counter value every so often.
            if (_counter % _OutputFrequency == 0)
            {
                Console.WriteLine($"Current counter: {_counter}.");
            }
            // Check if the counter has reached the maximum value.
            if (_counter <= _CounterMax)
            {
                // Recursively call self method.
                PreventativeExample();
            }
            else
            {
                Console.WriteLine("Recursion halted.");
            }
        }
        catch (System.StackOverflowException)
        {
            // Cannot catch StackOverflowException, so we'll just output a message.
            Console.WriteLine("StackOverflowException occurred.");
        }
    }
}