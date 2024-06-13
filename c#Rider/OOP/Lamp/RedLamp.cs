namespace Lamp;

public class RedLamp : ClassLamp
{
    public RedLamp() : base("red") { }

    public static void MredLamp()
    {
        ClassLamp lamp = new ClassLamp("red");
        lamp.TurnOn();

    }
}