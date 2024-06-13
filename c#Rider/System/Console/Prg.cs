using System;
using static System.Math;
using static System.Console;

namespace Console;

public class Prg
{
    static void Main(string[] args)
    {
        double dRootOfNine = System.Math.Sqrt(9);   // locale Variable
        
        WriteLine("Variable \n");
        WriteLine($"Root of {9} is  {Sqrt(9)} \n");
        WriteLine("Root of {1} is {0}" , Sqrt(9) , 9);
    }
}