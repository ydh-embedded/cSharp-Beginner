using System.Text;
using System;
using Lamp02;

namespace Lamp02;

public class Override
{

    
// Die Methode ToString wurde von der Elternklasse
// Object aus dem Namespace System weitervererbt. Die Implementierung von
// ToString genügt jedoch nicht unseren Anforderungen. Deshalb überschreiben
// wir sie hier.
    public override string ToString()
    {
        StringBuilder builder = new();
        builder.Append(this.GetType().Name)
            .Append("[")
            .Append(nameof(InstanzFeld.isOn) + "=" + InstanzFeld.isOn + ",")
            .Append(nameof(InstanzFeld.brightness) + "=" + InstanzFeld.brightness + ",")
            .Append(nameof(InstanceMethods.CanChangeBrightness) + "=" + InstanceMethods.CanChangeBrightness())
            .Append("]");

        return builder.ToString();
    }
}