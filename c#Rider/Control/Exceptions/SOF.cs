namespace Exceptions;

public class SOF
{
        
    private const int _CounterMax = 2;
    private const int _OutputFrequency = 1;                                             // Changed from 2 to 1
    private static int _counter = 0;

    public static void mPreventativeExample()
    {
        try
        {
            _counter++;                                                      // Iterate counter.
            if (_counter % _OutputFrequency == 0)                           // Output counter value every so often.
            {
                Console.WriteLine($"Current counter: {_counter}.");
            }
            if (_counter <= _CounterMax)                                // Check if the counter has reached the maximum value.
            {
                mPreventativeExample();                               // Recursively call self method.
            }
            else
            {
                Console.WriteLine("Recursion halted.");
            }
        }
        catch (System.StackOverflowException)
        {
            Console.WriteLine("StackOverflowException occurred.");  // Cannot catch StackOverflowException, so we'll just output a message.
        }
    }
}