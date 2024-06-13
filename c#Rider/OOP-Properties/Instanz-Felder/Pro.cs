namespace Instanz_Felder;

public class Pro
{
    public enum EnumOfCurrent
    {
        AC,
        DC
    }

    static void Main(string[] args) // main Method is here non-static
    {
           Console.WriteLine(TypeOfEnumOfCurrentv1); 
        // Console.WriteLine(TypeOfEnumOfCurrentv2); 
           Console.WriteLine(TypeOfEnumOfCurrentv3);
    }
    
    
    public int RequiredPowerInWatts { get; private set; }
    
    public bool IsconnectedToPowerSupply { get; private set; }
    
    
    //  Variante 1
    static public EnumOfCurrent TypeOfEnumOfCurrentv1 { get; set; }

    
    // Variante 3
    static protected EnumOfCurrent TypeOfEnumOfCurrentv3 { private get; set; }
}
