namespace Lamp;

public class BlueLamp : ClassLamp
{
    public BlueLamp() : base("blue") { }

    public static void MblueLamp()
    {
        ClassLamp lamp = new ClassLamp("blue");
        lamp.TurnOn();
    }
}