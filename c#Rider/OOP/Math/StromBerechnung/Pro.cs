namespace StromBerechnung.HeaderRider;


using System;
using HeaderRider;

public class Pro
{
    static void Main()
    {
        ClassHeader.MprintHead();
        
        double U, I, P;                                                                             // declare variables
        MyEnumClass currentType;                                                                // declare enum variable

        Console.Write("Enter the type of current (AC for Wechselstrom, DC for Gleichstrom): ");
        string currentTypeInput = Console.ReadLine();

        if (currentTypeInput.ToUpper() == "AC")
        {
            currentType = MyEnumClass.AC;
        }
        else if (currentTypeInput.ToUpper() == "DC")
        {
            currentType = MyEnumClass.DC;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter AC or DC.");
            return;
        }

        Console.Write("Enter the electrical voltage (in Volt): ");
        U = Convert.ToDouble(Console.ReadLine());                                               // read user input for U

        Console.Write("Enter the electrical current (in Ampere): ");
        I = Convert.ToDouble(Console.ReadLine());                                               // read user input for I

        P = U * I; // calculate P

        Console.WriteLine("The electrical power is: " + P + " Watt (" + currentType + ")");
    }
}