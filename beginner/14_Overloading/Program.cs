namespace _14_Overloading;

class Program
{
    static void Main(string[] args)
    {
                    Console.WriteLine(@"

            **************************************************************************

                    Operator Overloading

                    Most operators in C# can be overloaded,
                    meaning they can be redefined for custom actions.

                    For example, you can redefine the action of
                    the plus (+) operator in a custom class.

                    Consider the Box class that has Height and Width properties: 

                    Summary:

                    This is achieved through operator overloading

            **************************************************************************");
            Box box1 = new Box(14, 03) ;
            Box box2 = new Box(05, 07)  ;
            System.Console.WriteLine("");
            System.Console.WriteLine("Box 1: "+ box1.ToString());
            System.Console.WriteLine("Box 2: "+ box2.ToString());

                                Console.WriteLine(@"

            **************************************************************************

                    Addition Operator

                    The issue with your code is that you're trying to add
                    two Box objects together using the + operator,
                    but you haven't defined what that operation should do.
                    In C#, you need to overload the + operator to specify
                    how it should behave when used with your custom class.

                    Summary:

                    I added the operator + overload to the Box class,
                    which takes two Box objects as parameters and returns
                    a new Box object with the summed Height and Width properties.

            **************************************************************************");
            Box box3 = box1 + box2 ;
            System.Console.WriteLine("");
            System.Console.WriteLine("Box 3: "+ box3 + "  We added two Boxes");

    }
    class Box
    {
          public int Height {get; set;}
          public int Width {get; set;}
          public Box(int h, int w)
          {
                Height = h ;
                Width  = w ;
          }

          public static Box operator +(Box b1, Box b2)
          {
            return new Box(b1.Height + b2.Height, b1.Width + b2.Width);
          }

          public override string ToString()
          {
            return $"{Height}x{Width}";
          }
    } 
}