using Inheritence.Illumination;

namespace Inheritance.Illumination;

internal class Program
{
	static void Main(string[] args)
	{
		// Erstelle ein neues Lamp Objekt mit dem parameterlosen Konstruktor.
		Lamp nightLamp = new Lamp();
		Console.WriteLine(nightLamp.ToString()); // Lamp.ToString
		Console.WriteLine(nightLamp.GetName()); // Lamp.GetName
		Console.WriteLine(nightLamp.GetBrightness()); // Lamp.GetBrightness

		// Die Methode GetMaterial kann nicht mit nightLamp aufgerufen werden,
		// da sie in der Klasse Lamp nicht existiert.
		// nightLamp.GetMaterial()

		// Erstelle ein neues IncandescentLamp Objekt
		IncandescentLamp officeLamp = new IncandescentLamp();
		Console.WriteLine(officeLamp.ToString()); // Lamp.ToString
		Console.WriteLine(officeLamp.GetName()); // IncandescentLamp.GetName
		Console.WriteLine(officeLamp.GetMaterial()); // IncandescentLamp.GetMaterial
		Console.WriteLine(officeLamp.GetBrightness()); // Lamp.GetBrightness

		// Erstelle ein weiteres IncandescentLamp Objekt. Verwende jedoch ein
		// anderes Material.
		IncandescentLamp outdoorLamp = new IncandescentLamp("Coal");
		Console.WriteLine(outdoorLamp.ToString());
		Console.WriteLine(outdoorLamp.GetMaterial());

		// Erstelle weiteres IncandescentLamp Objekt.
		IncandescentLamp showerLamp = new(); // verkürzte Schreibweise
		showerLamp.SetMaterial("Copper");
		Console.WriteLine(showerLamp.ToString());

		// Ein Up-Cast ist erlaubt, da das Objekt auf der rechten Seite
		// alle Methoden und Felder besitzt, die im Datentyp auf der linken Seite
		// definiert sind.
		Lamp aLamp = showerLamp;
		// Ein Down-Cast findet nicht automatisch statt, da das Objekt auf der rechten Seite
		// eventuell nicht alle Methoden und Felder besitzt, die der Datentyp auf der linken
		// Seite definiert. Der Compiler lässt sich jedoch per explizitem Cast dazu zwingen.
		// IncandescentLamp il = nightLamp; // Fehler: 
		// il.GetMaterial();

	}
}
