using System.Text;

namespace Lamp02;

public abstract class InstanceMethods
{
    #region Instanzmethoden

    public virtual string GetName()     // wir schreiben hier die instance methode groß, weil diese nach außen Sichtbar ist -> public
    {
        return "Standard";
    }

    public bool TurnOn()
    {
        if (InstanzFeld.isOn) return false;                         // Gib true zurück, wenn die Lampe
        InstanzFeld.isOn = true;                                   // ihren Zustand tatsächlich gewechselt hat.
        return true;
    }

    public bool TurnOff()
    {
        if (!InstanzFeld.isOn) return false;                        // Gib true zurück, wenn die Lampe
        InstanzFeld.isOn = false;                                  // ihren Zustand tatsächlich gewechselt hat.
        return true;
    }

    public void Toggle()
    {
        InstanzFeld.isOn = !InstanzFeld.isOn;
    }

    public static bool CanChangeBrightness()
    {
        return false;
    }

    public void SetBrightness(double brightness)
    {
        if (InstanceMethods.CanChangeBrightness())
        {
            InstanzFeld.brightness = brightness;
        }
        else
        {
            throw new InvalidOperationException("Brightness cannot be changed!");
        }
    }

    public double GetBrightness()
    {
        return InstanzFeld.brightness;
    }






    #endregion
}