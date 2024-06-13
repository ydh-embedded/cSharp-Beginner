## bug 

````powershell
  <StromBerechnung>\Pro.cs:0 Source file can only contain single file-scoped namespace
  <StromBerechnung>\Pro.cs:27 Source file can only contain single file-scoped namespace
  <StromBerechnung>\Pro.cs:153 Cannot resolve symbol 'MprintHead'
  
````

````csharp
namespace HeaderRider;

public class ClassHeader
{
        public static void MprintHead()
    {
        Console.WriteLine("" +
                          "\n" +
                          "\n");
    }
}
````

````csharp
namespace StromBerechnung;
namespace HeaderRider;

using System;
using HeaderRider;

public class Pro
{
    static void Main()
    {
        HeaderRider.MprintHead();
    }
}
````


## Lösung

The first error, Source file can only contain single file-scoped namespace, is because you have defined two file-scoped namespaces (StromBerechnung and HeaderRider) in the same file. To fix this error, you can define the namespaces in separate files, or you can define a single namespace that encompasses both StromBerechnung and HeaderRider.





