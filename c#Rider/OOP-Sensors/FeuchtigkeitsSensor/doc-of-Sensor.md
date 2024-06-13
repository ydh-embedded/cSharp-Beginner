
## [Sensor.cs](Sensor.cs)

// Eine abstrakte Klasse dient als Vorlage für Unterklassen.
// Ihr einziger Zweck besteht darin, eine Grundlage für weitere Klassen anzubieten.
// Abstrakte Klassen dürfen abstrakte Methoden enthalten.
// Objekte können von abstrakten Klassen nicht erstellt werden.

````csharp
    namespace AbstractClasses;

        internal abstract class Sensor
        {
           // (...)
        }
````



// Hier machen wir Gebrauch von einem sogenannten Nullable Value Type.
// Ein Nullable Value Type erweitert einen herkömmlichen Value Type um
// den Wert null.

````csharp
	public double? LastValue { get; protected set; }
	public double? MaxValue { get; protected set; }
````


// variable?.methode() bedeutet: Rufe Methode nur auf, wenn variable != null ist, ansonsten gib null zurück.
// Dieser Operator heißt "Null-Conditional-Operator".
// wertA ?? wertB bedeutet: Wenn wertA null ist, nimm wertB, andernfalls wertA. Dieser Operator
// heißt "Null-Coalescing-Operator".

````csharp
	// Konstruktor
	protected virtual void TupelOfCollectFieldValues(List<(string Name, string Value)> fields)
	{
		fields.AddRange([
                
		(nameof(LastValue), LastValue ?. ToString("N2") ?? "N/A"),
		(nameof(AverageValue), AverageValue ?. ToString("N2") ?? "N/A"),
		(nameof(TotalMeasurements), TotalMeasurements.ToString()),
    
		]);
	}

````