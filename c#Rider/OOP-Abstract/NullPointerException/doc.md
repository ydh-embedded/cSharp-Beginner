




- In this example, we use the null conditional operator (?.)
- to access the Name property of person only if person is not null.
- If person is null, the null coalescing operator returns the right-hand operand,
- which is the string "Unknown".

- Using the null coalescing operator can make your code more concise and easier to read,
- especially when dealing with nullable types or objects that may be null.
- However, it is important to use it judiciously and ensure that the right-hand
- operand is a valid default value for the left-hand operand.

### [ClassofPerson.cs](ClassofPerson.cs)
`````csharp


    
     
namespace NullPointerException;

public class ClassofPerson
{
    public string Name { get; set; }
    public int Age { get; set; }
}
`````


### [Program.cs](Program.cs)
`````csharp

    
    
namespace NullPointerException;

public class Program
{
    public static void Main(string[] args)
    {
        ClassofPerson person = null;
        string name = person?.Name ?? "Unknown";
        Console.WriteLine(name); // Prints "Unknown"
    }
}
`````