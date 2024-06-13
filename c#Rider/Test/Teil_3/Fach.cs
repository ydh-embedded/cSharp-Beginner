namespace Teil_3;

public record Fach // record
{
    // Property
    public string Name { get; private set; }
    
    
    // Constructor
    public Fach(string name)
    {
        Name = name;
    }
}