namespace Teil_3;

using System;

public class Person
{
    // Props
    public int Alter { get; private set; }
    public string Vorname { get; private set; }
    public string Nachname { get; private set; }
    public DateOnly Geburtstag { get; private set; }
    public Geschlecht Geschlecht { get; private set; }
    public Adresse Adresse { get; private set; }

    public Person(string vorname, string nachname, Geschlecht _geschlecht, Adresse _adresse, DateOnly _geburtstag)
    {
        Vorname     = vorname;
        Nachname    = nachname;
        Adresse     = _adresse;
        Geburtstag  = _geburtstag;
        Geschlecht  = _geschlecht;
        BerechneAlter();
    }
    
    // Methods
    private void BerechneAlter()
    {
        // aktuelles Datum minus Geburtsdatum
        int currentYear = DateTime.Now.Year;
        int birthYear = Geburtstag.Year;
        Alter = currentYear - birthYear;
    }
}