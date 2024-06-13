using System;

namespace Expressions
{
    public class GoTo
    {
        public void mAge(int age)
        {
            startOver:
            switch (age)
            {
                case 2 or 4 or 6:
                    Console.WriteLine("Age is 2, 4, or 6");
                    break;
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                case 21:
                case 22:
                case 23:
                case 24:
                case 25:
                    Console.WriteLine("Age is between 16 and 25");
                    Console.WriteLine(age);
                    break;
                case 26:
                case 27:
                case 28:
                case 29:
                case 30:
                case 31:
                case 32:
                case 33:
                case 34:
                case 35:
                    Console.WriteLine("Age is between 26 and 35");
                    break;
                case 36:
                case 37:
                case 38:
                case 39:
                case 40:
                case 41:
                case 42:
                case 43:
                case 44:
                case 45:
                    Console.WriteLine("Age is between 36 and 45");
                    break;
                case 46:
                case 47:
                case 48:
                case 49:
                case 50:
                case 51:
                case 52:
                case 53:
                case 54:
                case 55:
                    Console.WriteLine("Age is between 46 and 55");
                    break;
                case 1:
                    Console.WriteLine("Age is 1");
                    goto startOver;                             // Go back to the start of the switch statement
                default:
                    Console.WriteLine("Age is unknown");
                    goto endMethod;                          // Jump to the end of the method
            }

            Console.WriteLine("Age is processed");
            endMethod:
            Console.WriteLine("Method ended");
        }
    }
}