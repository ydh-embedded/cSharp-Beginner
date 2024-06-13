namespace Expressions;

public class If_Pattern
{
    static void Main(string[] args)
    {
        int age = 0;
        
        if (age is (10 or 3 or >= 14 and <= 19) || (age % 2 == 0))
        {
            Console.WriteLine("If_Pattern"); 
        }
    }
}