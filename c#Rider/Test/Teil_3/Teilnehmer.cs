namespace Teil_3;
using static Teil_3.Kurs;

public class Teilnehmer
{
    // Subclass als record
    public record Kurs
    {
        public DateTime Beginn { get; init; }
        public DateTime Ende { get; init; }
    }
}