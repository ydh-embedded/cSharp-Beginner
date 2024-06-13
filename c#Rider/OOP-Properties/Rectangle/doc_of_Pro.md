# Rectangle

````csharp

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

````

- In this code, I created a new Rectangle object with a width of 5 and a height of 10,
- and passed it as a parameter to the MprintRectangel method.
- I also added the Area and Perimeter properties to the Rectangle class,
- which calculate their values based on the current values of Width and Height.
- Finally, I updated the MprintRectangel method to use the Rectangle object passed as a parameter instead of the r object,
- which was not initialized.
