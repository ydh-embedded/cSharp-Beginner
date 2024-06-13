using System.Text;

namespace Lampen;

public class ClassLamp
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

	public virtual bool TurnOn()
	{
		// Gib true zurück, wenn die Lampe
		// ihren Zustand tatsächlich gewechselt hat.
		if (this.isOn) return false;
		this.isOn = true;
		return true;
	}

	public virtual bool TurnOff()
	{
		// Gib true zurück, wenn die Lampe
		// ihren Zustand tatsächlich gewechselt hat.
		if (!this.isOn) return false;
		this.isOn = false;
		return true;
	}

	public void Toggle()
	{
		if (this.isOn)
		{
			this.TurnOff();
		}
		else
		{
			this.TurnOn();
		}
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
		List<string> fields = new();
		this.CollectFieldValues(fields);

		StringBuilder builder = new();
		builder.Append(this.GetType().Name).Append("[\n");
		foreach (string field in fields)
		{
			builder.Append("  ");
			builder.AppendLine(field);
		}
		builder.Append("]");

		return builder.ToString();
	}

	protected virtual void CollectFieldValues(List<string> fields)
	{
		fields.AddRange([
			nameof(isOn) + "=" + this.isOn,
			nameof(brightness) + "=" + this.brightness,
			nameof(CanChangeBrightness) + "=" + this.CanChangeBrightness()
		]);
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
