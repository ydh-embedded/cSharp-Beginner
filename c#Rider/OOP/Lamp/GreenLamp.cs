namespace Lamp;

public class GreenLamp : ClassLamp
{
    public GreenLamp() : base("green") { }


    public static void MgreenLamp()
    {
        ClassLamp lamp = new ClassLamp("green");
        lamp.TurnOn();
    }
}