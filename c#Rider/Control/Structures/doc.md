# Control.Structures

```csharp
using static System.Math;
using static System.Console;
using static System.Random;

namespace Structures;

public class Prg
{
    static void Main(string[] args)
    {
        mIfStatement();
    }


    static void mIfStatement()
    {
        var rng = new Random(); // Random Number Generator
        int age = rng.Next(5, 25); // Zufallszahl zwischen 5 und 25
        if (age >= 18)
        {
            WriteLine($"Mit {age} Jahren bist du volljährig");
        }
        else if (age <= 13)
        {
            WriteLine($"Mit {age} Jahren bist du noch ein Teenager, in {18-age} Jahre bist du volljährig!");
        }
        else
        {
            WriteLine($"Mit {age} Jahren musst du noch {18-age} Jahre warten, bis du volljährig wirst!");
        }
    }
    
}
```

## Pattern

### rational Pattern

### relation Pattern

