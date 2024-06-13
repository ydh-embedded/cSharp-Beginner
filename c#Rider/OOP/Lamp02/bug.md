````csharp
namespace Lamp02;
using System;
using Lamp02;

public class Konstruktor
{
InstanzFeld.CisOn = false;
InstanzFeld.Cbrightness = LowBrightness;
}
````

````csharp
namespace Lamp02;

public class InstanzFeld
{
    internal static bool isOn;

    internal static double brightness;          // private double brightness;
    
    public class CisOn
    {
    }
    public class Cbrightness
    {
    }

}
````