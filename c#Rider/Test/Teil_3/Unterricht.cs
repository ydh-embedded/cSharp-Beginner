namespace Teil_3;
using static Teil_3.ITerminiert;
using static Teil_3.Fach;

public class Unterricht
{
    // Props
    public bool IstSelbststudium { get; private set; }
    
    public DateTime Beginn { get; private set; }
    public DateTime Ende   { get; private set; }
    
    // Constructor
    public Unterricht(bool istSelbststudium, DateTime beginn, DateTime ende )
    {
        IstSelbststudium = istSelbststudium;
        Beginn = beginn;
        Ende = ende;
    }
    
    // Subclass als record
    public record Fach
    {
        public DateTime Beginn { get; init; }
        public DateTime Ende { get; init; }
    }
    
    // Collection der Teilnehmer
    public List<Teilnehmer> TeilnehmerListe { get; private set; } = new List<Teilnehmer>();

    // Collection
    public List<Unterricht> Unterrichte { get; private set; } = new List<Unterricht>();
}