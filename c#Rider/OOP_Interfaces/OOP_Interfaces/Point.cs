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