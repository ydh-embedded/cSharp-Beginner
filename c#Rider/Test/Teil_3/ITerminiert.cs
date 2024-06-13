namespace Teil_3;

public interface ITerminiert
{
    // Props
    int DauerInStunden { get; set; }
    
    public DateTime Beginn { get; set; }
    public DateTime Ende   { get; set; }

    // 
}