namespace OOP.Classes;

// House ist eine benutzerdefinierte Klasse, also ein Referenzdatentyp.
class House
{
	#region Instanzfelder
	// Für die folgenden Felder speichert jedes
	// Objekt seinen individuellen Wert ab.
	public string owner;
	double area;
	int color;
	int totalWindows;
	#endregion

	#region Statische Felder
	// Dieses Feld gehört zur Klasse und nicht zu
	// einem Objekt. Es existiert nur einmal im Speicher
	// und wird von allen Objekten "geteilt".
	// Statische Felder eignen sich besonders für die Definition von
	// Konstanten.
	public static readonly int GreyColor = 0;
	public static readonly int RedColor = 1;
	public static readonly int GreenColor = 2;
	static readonly int BlueColor = 3;
	public static int DefaultColor = GreyColor;
	#endregion

	#region Instanzmethoden
	// Eine Instanzmethode kann nur mit Hilfe eines Objektes aufgerufen werden.
	// Instanzmethoden haben Zugriff auf die Instanzfelder des Objektes.
	// Mit dem Bezeichner "this" kann die Instanzmethode das Objekt direkt ansprechen.
	// Instanzmethoden können auch auf statische Felder und statische Methoden zugreifen.
	public void Repair()
	{
		Console.WriteLine($"{this.owner} repariert sein Haus.");
	}

	public void Paint(int newColor)
	{
		Console.WriteLine($"{this.owner} streicht die Fassade mit Farbe {newColor}");
		this.color = newColor;
	}
	#endregion

	#region Statische Methoden
	// Eine statische Methode wird ohne Objekt aufgerufen. Folglich kann sie
	// auch nicht auf Instanzfelder zugreifen, sondern nur auf statische Felder
	// und statische Methoden. Es gibt an dieser Stelle kein "this".
	public static string GetDefinition()
	{
		return "Aus Wänden und Dach errichtetes Gebäude für Menschen.";
	}
	#endregion

	#region Konstruktoren
	// Ein Konstruktor initialisiert ein neu erstelltes Objekt.
	// Ein Objekt muss immer durch einen Konstruktor initialisiert werden!
	// Konstruktoren sind keine normalen Methoden und können nicht wiederholt
	// aufgerufen werden, nachdem das Objekt erstellt wurde.
	// Ein Konstruktor trägt denselben Namen wie seine Klasse.
	public House()
	{
		this.area = 0;
		// Das Instanzfeld color wird standardmäßig mit dem aktuellen Inhalt
		// des statischen Feldes DefaultColor initialisiert.
		this.color = House.DefaultColor;
		this.totalWindows = 2;
		this.owner = "unbekannt";
	}

	// Es ist üblich Überladungen des Konstruktors anzubieten, damit man
	// die Initialwerte gleich festlegen kann.
	public House(string owner, double area, int color, int totalWindows)
	{
		this.owner = owner;
		this.area = area;
		this.color = color;
		this.totalWindows = totalWindows;
	}
	#endregion
}
