using System.Text;

namespace Inheritance.Illumination;

class Lamp
{
	#region Instanzfelder
	private bool isOn;
	private double brightness;
	#endregion

	#region Statische Felder
	public const double LowBrightness = 300;
	#endregion

	#region Instanzmethoden
	public virtual string GetName()
	{
		return "Standard";
	}

	public bool TurnOn()
	{
		// Gib true zurück, wenn die Lampe
		// ihren Zustand tatsächlich gewechselt hat.
		if (this.isOn) return false;
		this.isOn = true;
		return true;
	}

	public bool TurnOff()
	{
		// Gib true zurück, wenn die Lampe
		// ihren Zustand tatsächlich gewechselt hat.
		if (!this.isOn) return false;
		this.isOn = false;
		return true;
	}

	public void Toggle()
	{
		this.isOn = !this.isOn;
	}

	public virtual bool CanChangeBrightness()
	{
		return false;
	}

	public void SetBrightness(double brightness)
	{
		if (this.CanChangeBrightness())
		{
			this.brightness = brightness;
		}
		else
		{
			throw new InvalidOperationException("Brightness cannot be changed!");
		}
	}

	public double GetBrightness()
	{
		return this.brightness;
	}

	// Die Methode ToString wurde von der Elternklasse
	// Object aus dem Namespace System weitervererbt. Die Implementierung von
	// ToString genügt jedoch nicht unseren Anforderungen. Deshalb überschreiben
	// wir sie hier.
	public override string ToString()
	{
		StringBuilder builder = new();
		builder.Append(this.GetType().Name).Append("[");
		this.CollectFieldValues(builder);
		builder.Append("]");

		return builder.ToString();
	}

	protected virtual void CollectFieldValues(StringBuilder builder)
	{
		builder
			.Append(nameof(isOn) + "=" + this.isOn + ",")
			.Append(nameof(brightness) + "=" + this.brightness + ",")
			.Append(nameof(CanChangeBrightness) + "=" + this.CanChangeBrightness());
	}

	#endregion

	#region Konstruktoren
	public Lamp()
	{
		this.isOn = false;
		this.brightness = LowBrightness;
	}
	#endregion

	#region Brain Storming
	// Beispiele für Instanzfelder: 
	// - Notwendige Energie
	// - Form des Lampenschirms
	// - Fassung der Lampe (legt fest, welche Glühbirnen einsetzbar sind)
	// - Leuchtkraft (in Lumen)
	// - Preis
	// - DIN-Norm (Lumen, Beleuchtungsart (direkt/indirekt))
	// - Farbtemperatur
	// - Zustand (ein/aus)
	// - Durchschnittliche Lebensdauer
	// - Anzahl der Glühbirnen
	// - Bezeichnung
	// - Maße

	// Beispiele für statische Felder:
	// - Liste von allen möglichen Leuchtmitteln
	// - Farbtemperatur kaltes Licht, warmes Licht, weißes Licht
	// - Arten von Lampen: Draht, Gas, Elektrisch
	// - Definition des Begriffs Lampe

	// Beispiele: Instanzmethoden
	// - einschalten und ausschalten
	// - Farbtemperatur einstellen
	// - Preis einstellen
	// - Glühbirne wechseln
	// - Leuchtkraft einstellen (Lumen)

	// Beispiele: Statische Methoden
	// - Auslesen der möglichen Leuchtmittel
	// - Leuchtmittelliste modifizieren
	#endregion
}
