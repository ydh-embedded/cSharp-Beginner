using Inheritance.Illumination;
namespace Lampen;

public class ClassOilLamp
{
    #region Instanzfelder
    private double dFillLevel;
    #endregion

    #region Instanzmethoden
    protected override void CollectFieldValues(List<string> fields)
    {
        base.CollectFieldValues(fields);
        fields.AddRange([
            nameof(dFillLevel) + "=" + this.dFillLevel,
        ]);
    }

    public override string GetName() => "Öllampe";

    public void Refill() => this.dFillLevel = 1.0;

    public double GetFillLevel() => this.dFillLevel;
    // Die obige Schreibweise nennt man Expression-Bodied Method.
    // Obige Schreibweise ist gleichbedeutend mit den folgenden Zeilen:
    //{
    //	return this.fillLevel;
    //}
    #endregion

    #region Konstruktoren
    // Bei diesem Konstruktor ist der Parameter fillLevel optional.
    // Wenn der Aufrufer keinen Wert für fillLevel angibt, wird
    // standardmäßig 1.0 verwendet.
    public OilLamp(double dFillLevel = 1.0)
    {
        // !(fillLevel >= 0 && fillLevel <= 1)
        if (dFillLevel is not (>= 0 and <= 1))
        {
            throw new ArgumentOutOfRangeException(nameof(dFillLevel), $"Muss im Bereich [0, 1] liegen!");
        }
        this.dFillLevel = dFillLevel;
    }
    #endregion

}
