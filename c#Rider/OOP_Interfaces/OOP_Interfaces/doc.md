## 🐳 Interfaces 

### 🐬 [Pro.cs](Pro.cs)

````csharp
namespace OOP_Interfaces;

public class Pro
{
    static void PrintPoint(IPoint p)
    {
        Console.WriteLine("x={0}, y={1}", p.X, p.Y);
        Console.WriteLine("Distance from origin = {0}", p.Distance);
    }

    static void Main()
    {
        IPoint p = new Point(2, 3);
        Console.Write("My Point: ");
        PrintPoint(p);
    }
}
````


### 🐬 [IPoint.cs](IPoint.cs)

````csharp

namespace OOP_Interfaces;

public interface IPoint
{
    int X { get; set; }
    int Y { get; set; }
    double Distance { get; }
}
````


### 🐬 [Point.cs](Point.cs)

````csharp
namespace OOP_Interfaces;

// public partial class Point : System.Object , IPoint
public partial class Point : IPoint
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public double Distance
    {
        get
        {
            return Math.Sqrt(X * X + Y * Y);
        }
    }
}
````

