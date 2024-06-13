## bug 

````powershell
  <StromBerechnung>\Pro.cs:143 Cannot resolve symbol 'MprintHead'
  
````

````csharp
namespace StromBerechnung.HeaderRider;

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
namespace StromBerechnung.HeaderRider;


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

- This line imports the StromBerechnung.HeaderRider namespace, which contains the ClassHeader class. After adding this line, you should be able to call the MprintHead method without using the fully-qualified name:

- Alternatively, you can also call the MprintHead method using the fully-qualified name (ClassHeader.MprintHead()), but using a using directive is generally considered to be a better practice, as it makes the code more readable and easier to maintain.

````csharp
namespace StromBerechnung.HeaderRider;


using System;
using HeaderRider;

public class Pro
{
    static void Main()
    {
        ClassHeader.MprintHead();
        
        double U, I, P;                                                                             // declare variables
        MyEnumClass currentType;                                                                // declare enum variable
    
        // (...)
    }
}
````


