namespace Car;


public class ClassCar
{
                         
    private string color;                                                           // Instance field "private string "
                                      
    private static int numberOfCars = 0;                                            // Class field (shared by all instances) "private static int"
                             
    public void StartEngine()                                                        // Instance method "public void"
    {
        Console.WriteLine($"The car with color {color} has started its engine");
    }
                                       
    public static int GetNumberOfCars()                                             // Static method "public static int"
    {
        return numberOfCars;
    }
                      
    public ClassCar()                                                              // 2 Constructors of this class "public"
    {
        color = "";
        numberOfCars++;
    }
    
    
    public ClassCar(string color)
    {
        this.color = color;
        numberOfCars++;
    }
}