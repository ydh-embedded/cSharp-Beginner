using System;

namespace Expressions;

public class Parenthesis_Pattern
{
    public void mAge(int age)
    {
        myLabel:
        switch (age)
        {
            case 2 or 4 or 6:
                Console.WriteLine("");
                break;
            case (6 or 1) or 2:                                      // Klammern setzen, um den Vorrang zu definieren:
                Console.WriteLine("Parenthesis_Pattern");
                break;
            default:
                Console.WriteLine();
                goto myLabel;                                       // Mit dem goto kann man zu einer bestimmten Switch anweisung springen (Gefahr von Spagetti Code)
                break;
        }
    }
    
}