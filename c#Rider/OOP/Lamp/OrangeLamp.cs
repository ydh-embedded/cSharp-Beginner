namespace Lamp;

public class OrangeLamp : ClassLamp
{
    public OrangeLamp() : base("orange") { }

    public static void MorangeLamp()
    {
        ClassLamp lamp = new ClassLamp("orange");
        lamp.TurnOn();
    }
}