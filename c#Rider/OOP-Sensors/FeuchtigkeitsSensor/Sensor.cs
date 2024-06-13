using System.Text;

namespace AbstractClasses;

internal abstract class Sensor
{
	public string SOfManufacturer { get; }
	public string SofSOfSerialNumber { get; }
	public string SOfModel { get; }
	public Guid ID { get; }
	public abstract string SofUnit { get; }

	public double? LastValue { get; protected set; }
	public double? MaxValue { get; protected set; }
	public double? MinValue { get; protected set; }
	public int IofTotalMeasurements { get; protected set; }
	public double? DofAverageValue { get; private set; }

	public virtual void Reset()
	{
		
		DofAverageValue = LastValue = MinValue = MaxValue = null;					// Wir entfernen alle Messwerte.
		IofTotalMeasurements        = 0;
	}

	public double Measure()
	{
		LastValue = this.MtoMeasureCurrentValue();
		IofTotalMeasurements++;

															// Falls MinValue noch null ist, verwende LastValue.
		MinValue ??= LastValue;								// if (MinValue is null) MinValue = LastValue

															// Falls MinValue noch null ist, verwende LastValue.
		MaxValue ??= LastValue;								// if (MaxValue is null) MaxValue = LastValue
		DofAverageValue ??= LastValue;

		if (MinValue > LastValue) MinValue = LastValue;
		if (MaxValue < LastValue) MaxValue = LastValue;

		DofAverageValue = (DofAverageValue * (IofTotalMeasurements - 1) + LastValue) / IofTotalMeasurements;

		return LastValue ?? 0;								// Falls LastValue null ist, nimm Ersatzwert 0.
	}

	// Eine abstrakte Methode besitzt keine Implementierung.
	// Unterklassen _müssen_ diese Methode überschreiben bzw. implementieren.
	// Es handelt sich hier um eine "Lücke" der Klasse.
	// Hinweis: Abstrakte Methoden sind automatisch virtual, ansonsten könnte man
	// sie ja gar nicht in Unterklassen überschreiben.
	protected abstract double MtoMeasureCurrentValue();

	// Konstruktor
	protected virtual void TupelOfCollectFieldValues(List<(string Name, string Value)> fields)
	{
		fields.AddRange([
			(nameof(SOfManufacturer), SOfManufacturer),
			(nameof(SofSOfSerialNumber), SofSOfSerialNumber),
			(nameof(SOfModel), SOfModel),
			(nameof(ID), ID.ToString()),
			(nameof(SofUnit), SofUnit),

			(nameof(MinValue),       MinValue ?  . ToString("N2") ?? "N/A"),
			(nameof(MaxValue),       MaxValue ?  . ToString("N2") ?? "N/A"),
			(nameof(LastValue),      LastValue ? . ToString("N2") ?? "N/A"),
			(nameof(DofAverageValue), DofAverageValue ?. ToString("N2") ?? "N/A"),
			
			(nameof(IofTotalMeasurements), IofTotalMeasurements.ToString()),

		]);
	}

	public override string ToString()
	{
		StringBuilder sOfBuilder = new();
		sOfBuilder
			.Append(GetType().FullName)
			.AppendLine("[");

		List<(string Name, string Value)> sOfFields = [];
		this.TupelOfCollectFieldValues(sOfFields);

		const string indent = "\t";
		foreach (var field in sOfFields)
		{
			sOfBuilder.AppendLine(indent + field.Name.PadRight(20) + ": " + field.Value);
		}

		sOfBuilder.Append("]");
		return sOfBuilder.ToString();
	}

	public Sensor(string sOfManufacturer, string sOfModel, string sOfSerialNumber)
	{
		SOfManufacturer     = sOfManufacturer;
		SOfModel            = sOfModel;
		SofSOfSerialNumber  = sOfSerialNumber;
		ID                  = Guid.NewGuid();							 // Global Unique ID (immutable)
		
		DofAverageValue = MinValue = MaxValue = LastValue = null;
		IofTotalMeasurements = 0;
	}

}
