# OOP

## class Definition

````csharp
namespace Lamp;

public class ClassLamp
{
    
                         
    private string color;                             // Instance field "private string "

                                        
    private static int numberOfLamps = 0;             // Class field (shared by all instances) "private static int"

                        
    public void TurnOn()                              // Instance method "public void"
    {
        Console.WriteLine($"The lamp with color {color} is turned on");
    }

                                        
    public static int GetNumberOfLamps()              // Static method "public static int"
    {
        return numberOfLamps;
    }

                      
    public ClassLamp()                                // 2 Constructors of this class "public"
    {
        color = "white";
        numberOfLamps++;
    }

    public ClassLamp(string color)
    {
        this.color = color;
        numberOfLamps++;
    }
}
````