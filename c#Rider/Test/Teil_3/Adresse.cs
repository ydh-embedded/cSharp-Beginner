namespace Teil_3;

public class Adresse
{
    public string Hausnummer { get; set; }
    public string Ort { get; set; }
    public string Postleitzahl { get; set; }
    public string Strasse { get; set; }
    
    
    private Adresse _adresse = new Adresse()
    {
        Strasse = "Straße",
        Hausnummer = "111",
        Postleitzahl = "99995",
        Ort = "Erfurt"
    };
    
}