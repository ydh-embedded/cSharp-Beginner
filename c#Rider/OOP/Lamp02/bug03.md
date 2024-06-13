## Bug

````powershell
<Lamp02>\InstanzMethode.cs (2 errors)
      <Lamp02>\InstanzMethode.cs:24 Cannot resolve symbol 'InstanzMethods'
        <Lamp02>\InstanzMethode.cs:82 There is no suitable method for override
````

````csharp
namespace Lamp02;
using InstanzMethods;

public class InstanzMethode
{
    public override string GetName()
    {
        return "Glühlampe";
    }
}
````

````csharp
using System.Text;

namespace Lamp02;

public abstract class InstanceMethods
{
    #region Instanzmethoden

    public virtual string GetName()     // wir schreiben hier die instance methode groß, weil diese nach außen Sichtbar ist -> public
    {
        return "Standard";
    }
````

## Lösung:

````csharp
namespace Lamp02;
// using InstanzMethods;                                // Add this line to include the InstanzMethods namespace

public class InstanzMethode : InstanceMethods         // Inherit from the InstanceMethods base class
{
    public override string GetName()                // Override the GetName method from the base class
    {
        return "Glühlampe";
    }
}
````

