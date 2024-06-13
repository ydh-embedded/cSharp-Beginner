namespace OOP.Classes.Programs;

public class Program
{
	static void Main(string[] args)
	{
		// Mit dem Operator new erstellen wir ein neues House-Object.
		// Wir müssen uns an dieser Stelle für einen der bereitgestellten
		// House Konstruktoren entscheiden.
		House iadBuilding = new House("alice", area: 500, House.GreyColor, 20);
		House dorintHotel = new House("bob", area: 2500, House.GreenColor, 50);
		// Setze die Default Color für neu erstellte House Objekte auf Red.
		// Diese Farbeinstellung wird jedoch nur im Konstruktor House() genutzt.
		House.DefaultColor = House.RedColor;
		// Bei diesem Objekt verwenden wir den parameterlosen Konstruktor.
		House defaultHouse = new House();

		// Um auf ein Instanzfeld F eines Objektes o zuzugreifen,
		// schreibe o.F im Code.
		iadBuilding.owner = "Charlie";
		// Um auf ein statisches Feld F einer Klasse K zuzugreifen,
		// schreibe K.F im Code
		House.DefaultColor = 1;

		// Der Zugriff auf private Felder eines Objektes ist nur zulässig,
		// wenn er innerhalb der Klasse stattfindet, zu der das Objekt gehört.
		// iadBuilding.area = 120; // Fehler: area ist privates Instanzfeld!

		// Der Zugriff auf public Felder eines Objektes ist überall zulässig.
		iadBuilding.owner = "Damian"; // OK: owner ist public Instanzfeld!
	}

}
