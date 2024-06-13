namespace Lampen;
namespace Inheritance.Illumination;
using System.Text;

public class ClassElectricLamp : ClassLamp
{
    #region Instanzfelder
    private int requiredPowerInWatts;
    private bool isConnectedToPowerSupply;
    private EnumCurrent typeOfCurrent;
    #endregion

    #region Instanzmethoden
    protected override void CollectFieldValues(List<string> fields)
    {
        base.CollectFieldValues(fields);
        fields.AddRange([
            nameof(requiredPowerInWatts) + "=" + this.requiredPowerInWatts,
            nameof(isConnectedToPowerSupply) + "=" + this.isConnectedToPowerSupply,
            nameof(typeOfCurrent) + "=" + this.typeOfCurrent
        ]);
    }

    public void ConnectToPowerSupply()
    {
        if (this.isConnectedToPowerSupply) return;
        this.isConnectedToPowerSupply = true;
    }

    public void DisconnectFromPowerSupply()
    {
        if (!this.isConnectedToPowerSupply) return;
        this.isConnectedToPowerSupply = false;
        this.TurnOff();
    }

    public override bool TurnOn()
    {
        if (!this.isConnectedToPowerSupply) return false;
        return base.TurnOn(); // Rufe Basisimplementierung auf!
    }

    public bool IsConnectedToPowerSupply() => this.isConnectedToPowerSupply;

    public int GetPowerInWatts() => this.requiredPowerInWatts;

    public EnumCurrent GetTypeOfCurrent() => this.typeOfCurrent;
    #endregion

    #region Konstruktoren
    public ElectricLamp(int power = 0, EnumCurrent current = EnumCurrent.Direct, bool isConnected = false)
    {
        this.typeOfCurrent = current;
        this.requiredPowerInWatts = power;
        this.isConnectedToPowerSupply = isConnected;
    }
    #endregion
}
