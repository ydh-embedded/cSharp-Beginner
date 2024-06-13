// System.Drawing.Rectangle
namespace Rectangle
{
    public class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(5, 10);
            MprintRectangel(r);
        }

        static void MprintRectangel(Rectangle r)
        {
            Console.WriteLine($"Area: {r.Area} Perimeter: {r.Perimeter}");
        }
    }

    public class Rectangle
    {
        public double Width { get; private set; }
        public double Height { get; private set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Area
        {
            get
            {
                return Width * Height;
            }
        }

        public double Perimeter
        {
            get
            {
                return 2 * (Width + Height);
            }
        }
    }
}