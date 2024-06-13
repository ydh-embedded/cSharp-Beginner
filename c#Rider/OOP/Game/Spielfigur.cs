namespace Game;

public class Spielfigur
{
    // Eigenschaften
    public string Name { get; set; }
    public int Alter { get; set; }
    
    // Methoden
    public void SageHallo()
    {
        Console.WriteLine(Name + " sagt: Hallo");
    }
}