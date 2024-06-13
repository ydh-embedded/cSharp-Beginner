namespace Expressions;

public class Iterator
{
    // Wir machen eine Fall-Unterscheidung mit Switch
    static void mSwitchStatement()
    {
        for (int i = 0; i < 10; i++)
        {
            switch (i)
            {
                case 0:
                    Console.WriteLine("Number is 0");
                    break;
                case 1:
                    Console.WriteLine("Number is 1");
                    break;
                case 2:
                    Console.WriteLine("Number is 2");
                    break;
                default:
                    Console.WriteLine("Number is greater than 2");
                    break;
            }
        }
    }
}