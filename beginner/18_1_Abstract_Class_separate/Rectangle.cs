namespace _18_1_Abstract_Class_separate;

//REVIEW - Rectangle reference the IShape interface
public class Rectangle : Shape
{
    public override void Draw()
    {
        System.Console.WriteLine("Rectangle Draw");
    }
}