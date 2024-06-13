namespace Teil_3;

public class Program
{
    static void Main(string[] args)
    {
        // Instance "UML"
        Fach _fach_UML = new Fach("UML");
        Console.WriteLine($"Fach: {_fach_UML.Name}");
        
        // Instance "FIAE-36"
        Kurs _kurs_FIAE = new Kurs("FIAE-36");
        Console.WriteLine($"Kurs: {_kurs_FIAE.Name}");
        
        // Instance "Max"
        Adresse _adresse = new Adresse();
        DateOnly _geburtstag = new DateOnly(1990, 8, 18);
        Geschlecht geschlecht = Geschlecht.Mannlich;
        
        Person _max = new Person("Max", "Mustermann", geschlecht, _adresse, _geburtstag);
        
        // Ausgabe
        MofPrintPerson(_max);
    }

    public static void MofPrintPerson(Person person)
    {
        Console.WriteLine(" ");
        Console.WriteLine(" " + 
                          $"Vorname: {person.Vorname}" +
                          $"Nachname: {person.Nachname}" +
                          $"Geburtstag: {person.Geburtstag}" +
                          $"Geschlecht: {person.Geschlecht}" +
                          " "
        );
    }
}