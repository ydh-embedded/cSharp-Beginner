namespace Expressions;

public class Case_Guard
{


    
    static void mSwitchStatementWithCaseGuard()
    {
        for (int i = 0; i < 10; i++)
        {
            switch (i)
            {
                case int n when n == 0:                                                                                 // Der Case-Guard nimmt die Bedingung when n gleich erstellte Bedingung
                    Console.WriteLine("Number is 0");
                    Console.WriteLine(n);
                    break;
                case int n when n == 1:                                                                                 // Der Case-Guard nimmt die Bedingung when n gleich erstellte Bedingung
                    Console.WriteLine("Number is 1");
                    Console.WriteLine(n);
                    break;
                case int n when n == 2:                                                                                 // Der Case-Guard nimmt die Bedingung when n gleich erstellte Bedingung
                    Console.WriteLine("Number is 2");
                    Console.WriteLine(n);
                    break;
                case int n when n % 2 == 0:                                                                             // Der Case-Guard nimmt die Bedingung when n gleich erstellte Bedingung
                    Console.WriteLine("Number is even");
                    Console.WriteLine(n);
                    break;
                case int n when n % 2!= 0:                                                                              // Der Case-Guard nimmt die Bedingung when n gleich erstellte Bedingung
                    Console.WriteLine("Number is odd");
                    Console.WriteLine(n);
                    break;
                default:
                    Console.WriteLine("Number is greater than 2");
                    break;
            }
        }
    }
}
