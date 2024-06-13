namespace Lamp02;
// using InstanzMethods;                                // Add this line to include the InstanzMethods namespace

public class InstanzMethode : InstanceMethods         // Inherit from the InstanceMethods base class
{
    public override string GetName()                // Override the GetName method from the base class
    {
        return "Glühlampe";
    }
}