﻿namespace Testing;

using System.Runtime.InteropServices;
using System.Threading.Tasks.Dataflow;
using System.Reflection;
using System;



public class Pro
{
    [DllImport("msvcrt.dll")] private static extern int system(string cmd); // wir lesen die dll Datei ein um funktionen wie clear im Terminal nutzen zu können
    private static void Header()
    {
        string logo = System.IO.File.ReadAllText(@"ASCII\logo.txt");     // Read the contents of the logo.txt file
           
        Console.WriteLine(logo);                                            // Display the logo
    }                                       // Logo - HEADER
    private static void GetInput()
    {
        Console.WriteLine("Please enter the first number:");
        string input1 = Console.ReadLine();
        int n1 = Convert.ToInt32(input1);

        Console.WriteLine("Please enter the second number:");
        string input2 = Console.ReadLine();
        int n2 = Convert.ToInt32(input2);

        Calculator calculator = new Calculator();
        Calculator result = calculator.Add(n1, n2);

        Console.WriteLine("The sum of " + n1 + " and " + n2 + " is: " + result.Value);
    }                                     // Get-Input - Eingabe
    
    
    
    
    
    private static void Main(string[] args)
    {
        system("cls");
        
        Header();
        GetInput();
    }                           // Einhängepunkt vom Programm
    
    public class Calculator
    {
        public int Value { get; private set; }

        public Calculator(int value = 0)
        {
            Value = value;
        }

        public Calculator Add(int a, int b)
        {
            return new Calculator(a + b);
        }
    }
}