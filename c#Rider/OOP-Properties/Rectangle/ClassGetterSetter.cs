namespace Rectangle;

public class ClassGetterSetter
{
    public double Height { get; set; }
    public double Width { get; set; }
    public double Area => Height * Width;
    public double Permimeter => 2 * ( Height * Width);
}