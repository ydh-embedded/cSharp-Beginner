using Car;
using Rider_VS_Studio;


namespace App;
         // Add this line at the top of your file

public static class Pro
{
    private static void Main()
    {

        Header_of_Rider.MprintHeadofRider();                   // Call the MprintHead method from the Pro class in the HeaderRider namespace
        
        var iNumberOfCars = ClassCar.GetNumberOfCars();
        Console.WriteLine($"Number of cars: {iNumberOfCars}");
        
    }
}
