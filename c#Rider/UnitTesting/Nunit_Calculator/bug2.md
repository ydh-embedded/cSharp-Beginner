````csharp
<Nunit_Temperature>\Pro.cs (2 errors)
      <Nunit_Temperature>\Pro.cs:88 Method, delegate, or event is expected
      <Nunit_Temperature>\Pro.cs:110 Unrecognized escape sequence
````

````csharp Pro.cs

namespace Nunit_Calculator;
using System.Threading.Tasks.Dataflow;
using System.Reflection;
using Nunit_Calculator;
using System;


public class Pro
{
    private static extern int _system(string cmd);
    static void Header()
    {
        string logo = System.IO.File.ReadAllText("ASCII/logo.txt");     // Read the contents of the logo.txt file
           
        Console.WriteLine(logo);                                            // Display the logo
    }                                       // Logo - HEADER
    static void GetInput()
    {
        Console.WriteLine("Please enter a number:");
        string input = Console.ReadLine();
        int n = Convert.ToInt32(input);
        Console.WriteLine("You entered: " + n);
    }                                     // Get-Input - Eingabe
    
    private static void Main(string[] args)
    {
        Header();
        _system("cls");
        GetInput();
    }                           // Einhängepunkt vom Programm
    
    public Calculator Add(int a, int b)
    {
            return new Calculator(a + b);
    }
}

````