using Lampen.Inheritance;
using Lampen.Inheritance.Illumination;

namespace Lampen;

internal class Pro
{
    static void Main(string[] args)
    {
		// Erstelle ein neues Lamp Objekt mit dem parameterlosen Konstruktor.
		ClassLamp nightLamp = new ClassLamp();
		Console.WriteLine(nightLamp.ToString()); // Lamp.ToString
		Console.WriteLine(nightLamp.GetName()); // Lamp.GetName
		Console.WriteLine(nightLamp.GetBrightness()); // Lamp.GetBrightness

		// Die Methode GetMaterial kann nicht mit nightLamp aufgerufen werden,
		// da sie in der Klasse Lamp nicht existiert.
		// nightLamp.GetMaterial()

		// Erstelle ein neues IncandescentLamp Objekt
		ClassIncandescentLamp officeLamp = new ClassIncandescentLamp();
		Console.WriteLine(officeLamp.ToString()); // Lamp.ToString
		Console.WriteLine(officeLamp.GetName()); // IncandescentLamp.GetName
		Console.WriteLine(officeLamp.GetMaterial()); // IncandescentLamp.GetMaterial
		Console.WriteLine(officeLamp.GetBrightness()); // Lamp.GetBrightness

		// Erstelle ein weiteres IncandescentLamp Objekt. Verwende jedoch ein
		// anderes Material.
		ClassIncandescentLamp outdoorLamp = new ClassIncandescentLamp("Coal");
		Console.WriteLine(outdoorLamp.ToString());
		Console.WriteLine(outdoorLamp.GetMaterial());

		// Erstelle weiteres IncandescentLamp Objekt.
		ClassIncandescentLamp showerLamp = new(); // verkürzte Schreibweise
		showerLamp.SetMaterial("Copper");
		Console.WriteLine(showerLamp.ToString());

		// Ein Up-Cast ist erlaubt, da das Objekt auf der rechten Seite
		// alle Methoden und Felder besitzt, die im Datentyp auf der linken Seite
		// definiert sind.
		ClassLamp aLamp = showerLamp;
		// Ein Down-Cast findet nicht automatisch statt, da das Objekt auf der rechten Seite
		// eventuell nicht alle Methoden und Felder besitzt, die der Datentyp auf der linken
		// Seite definiert. Der Compiler lässt sich jedoch per explizitem Cast dazu zwingen.
		// IncandescentLamp il = nightLamp; // Fehler: Impliziter Cast nicht möglich.
		// il.GetMaterial();

		ClassOilLamp oilLamp = new();
		Console.WriteLine(oilLamp); // WriteLine ruft automatisch ToString Methode auf

		ClassOilLamp emptyOilLamp = new(0);
		Console.WriteLine(emptyOilLamp);

		ClassOilLamp aladinsLamp = new(0.5);
		Console.WriteLine(aladinsLamp);
		aladinsLamp.Refill();
		Console.WriteLine(aladinsLamp);

		//OilLamp brokenLamp = new(2.5);

		ClassElectricLamp led = new(power: 5, EnumCurrent.Direct, false);
		Console.WriteLine(led);
		Console.WriteLine("Versuche einzuschalten...");
		led.TurnOn();
		Console.WriteLine(led);
		// Versuche aktuellen Ein/Aus Zustand zu wechseln.
		Console.WriteLine("Versuche auszuschalten...");
		led.Toggle(); // Hat keinen Effekt, da Lampe disconnected.
		Console.WriteLine(led);
		Console.WriteLine("Verbinde mit Energiequelle...");
		led.ConnectToPowerSupply();
		Console.WriteLine(led);
		Console.WriteLine("Versuche einzuschalten...");
		led.TurnOn();
		Console.WriteLine(led);
		Console.WriteLine("Schalte Ein/Aus Zustand um...");
		led.Toggle();
		Console.WriteLine(led);
		Console.WriteLine("Schalte Ein/Aus Zustand um...");
		led.Toggle();
		Console.WriteLine(led);
		Console.WriteLine("Trenne von Energiequelle...");
		led.DisconnectFromPowerSupply();
		Console.WriteLine(led);

	}

	// Diese Methode dient nur zu Anschauungszwecken und sollte
	// nicht ausgeführt werden, da sie einen StackOverflow erzeugt.
	public static void F(int a, int b, int c = 2, int d = 5)
	{
		// Argumente für Parameter können per Name oder per Position angegeben werden.
		F(2, 4, d: 10); // a = 2, b = 4, c = 2, d = 10
		F(3, 5, 4, 1);  // a = 3, b = 5, c = 4, d = 1  
		F(3, 5, 4);     // a = 3, b = 5, c = 4, d = 5
		F(d: 1, a: 2, b: 7, c: 2); // a = 2, b = 7, c = 2, d = 1
	}
}
