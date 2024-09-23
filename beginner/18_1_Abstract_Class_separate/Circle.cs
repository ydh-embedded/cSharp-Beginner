namespace _18_1_Abstract_Class_separate;

//REVIEW - Circle reference the IShape

public class Circle : Shape
{
    public override void Draw()
    {
        System.Console.WriteLine("Circle Draw");
    }
}