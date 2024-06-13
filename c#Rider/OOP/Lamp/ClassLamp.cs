namespace Lamp;

public class ClassLamp
{
// Instance field "private string "
    private string color;

// Class field (shared by all instances) "private static int"
    private static int numberOfLamps = 0;

// Instance method "public void"
    public void TurnOn() 
    {
        Console.WriteLine($"The lamp with color {color} is turned on");
    }

// Static method "public static int"
    public static int GetNumberOfLamps()
    {
        return numberOfLamps;
    }

// 2 Constructors of this class "public"
    public ClassLamp()
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