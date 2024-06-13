using System.Text;
using Lampen.Inheritance.Illumination;

namespace Lampen;
// using Inheritance.Illumination;
// namespace Inheritence.Illumination;

// Diese Klasse ist die Basisklasse für Glühlampen.
// Eine Glühlampe erzeugt Licht, indem sie ein Material
// durch Energie zum Glühen bringt.

class ClassIncandescentLamp : ClassElectricLamp
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

    protected override void CollectFieldValues(List<string> fields)
    {
        // Rufe zuerst die Implementierung der Basisklasse auf.
        base.CollectFieldValues(fields);
        fields.AddRange([
            nameof(material) + "=" + this.material,
        ]);
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
