namespace Teil_3;

public record Kurs
{
    // Property
    public string Name { get; private set; }
    
    // Constructor
    public Kurs(string name)
    {
        Name = name;
    }
}