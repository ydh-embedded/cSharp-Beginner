using Inheritance.Illumination;
using System.Text;

namespace Inheritence.Illumination;

// Diese Klasse ist die Basisklasse für Glühlampen.
// Eine Glühlampe erzeugt Licht, indem sie ein Material
// durch Energie zum Glühen bringt.
class IncandescentLamp : Lamp
{
	private string material;
	public const string Wolfram = "Wolfram";

	public override string GetName()
	{
		return "Glühlampe";
	}

	public string GetMaterial()
	{
		return this.material;
	}

	public void SetMaterial(string material)
	{
		this.material = material;
	}

	protected override void CollectFieldValues(StringBuilder builder)
	{
		// Rufe zuerst die Implementierung der Basisklasse auf.
		base.CollectFieldValues(builder);
		// Füge nun noch noch die eigenen Feldwerte zum Builder hinzu.
		builder.Append("," + nameof(material) + "=" + this.material);
	}

	public IncandescentLamp() : base()
	{
		this.material = Wolfram;
	}

	public IncandescentLamp(string material) : base()
	{
		this.material = material;
	}

}
