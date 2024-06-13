You're referring to the [Conditional("DEBUG")] attribute in C#.

The [Conditional("DEBUG")] attribute is used to specify that a method or class should only be called when the DEBUG conditional compilation symbol is defined. This means that when you compile your code in debug mode, the method or class will be included, but when you compile in release mode, it will be omitted.

To use this attribute to print debug information automatically, you can create a method with the [Conditional("DEBUG")] attribute and call it from your code. Here's an example:

csharp
Verify
Edit
Full Screen

`````csharp
[Conditional("DEBUG")]
public static void PrintDebugInfo(string message)
{
    Console.WriteLine($"DEBUG: {message}");
}
`````


- Then, in your code, you can call this method like this:

````csharp
PrintDebugInfo("Entering method Foo");

````

- When you compile your code in debug mode, the PrintDebugInfo method will be called and will print the message to the console. When you compile in release mode, the method call will be omitted, and no output will be printed.

Note that the [DoesNotReturn] attribute is not related to printing debug information. It's used to indicate that a method does not return, which can help the compiler and code analyzers understand the flow of your code.

If you want to print debug information automatically without having to call a method explicitly, you can use a technique called "aspect-oriented programming" (AOP). One way to do this is by using a library like PostSharp, which allows you to create aspects that can inject code into your methods automatically.

For example, you can create an aspect that prints debug information whenever a method is entered or exited:


````csharp
[Serializable]
public class DebugAspect : OnMethodBoundaryAspect
{
    public override void OnEntry(MethodExecutionArgs args)
    {
        Console.WriteLine($"DEBUG: Entering {args.Method.Name}");
    }

    public override void OnExit(MethodExecutionArgs args)
    {
        Console.WriteLine($"DEBUG: Exiting {args.Method.Name}");
    }
}
````


- Then, you can apply this aspect to your methods or classes using attributes:
- 
````csharp
 [DebugAspect]
public void Foo()
{
    // method implementation
}
````

- When you run your code in debug mode, the aspect will print debug information automatically whenever the Foo method is entered or exited.

## Version

- What are the alternatives to [Conditional("DEBUG")] for printing debug information in C#?

There are several alternatives to using the [Conditional("DEBUG")] attribute for printing debug information in C#. Here are some of them:

Using #if DEBUG preprocessor directives:
````csharp
#if DEBUG
    Console.WriteLine("DEBUG: Entering method Foo");
#endif
````



This approach allows you to conditionally compile code based on the DEBUG symbol, similar to the [Conditional("DEBUG")] attribute. However, it requires you to manually add the preprocessor directives to your code.

Using a logging library: There are many logging libraries available for C#, such as NLog, Log4Net, and Serilog. These libraries allow you to configure logging levels and output formats, and can be used to print debug information automatically based on your configuration.
Here's an example using Serilog:

````csharp
using Serilog;

public static void Main()
{
    Log.Logger = new LoggerConfiguration()
        .WriteTo.Console()
        .CreateLogger();

    Log.Debug("Entering method Foo");

    // method implementation
}
````

Using a custom debug class: You can create a custom debug class that provides methods for printing debug information, and use it throughout your code. This approach allows you to centralize your debugging code and make it easier to enable or disable debugging as needed.

````csharp
public static class DebugHelper
{
    public static void PrintDebugInfo(string message)
    {
#if DEBUG
        Console.WriteLine($"DEBUG: {message}");
#endif
    }
}

public void Foo()
{
    DebugHelper.PrintDebugInfo("Entering method Foo");

    // method implementation
}
````

Using a debugger visualizer: A debugger visualizer is a tool that allows you to inspect complex objects in the debugger. You can create a custom debugger visualizer for your objects and use it to print debug information automatically.
Here's an example:

````csharp
[DebuggerDisplay("Name = {Name}, Age = {Age}")]
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public void Foo()
{
    var person = new Person { Name = "John Doe", Age = 30 };

    // method implementation
}
````

In this example, the DebuggerDisplay attribute is used to specify how the Person object should be displayed in the debugger. When you inspect the person object in the debugger, it will display the Name and Age properties automatically.

Overall, there are many alternatives to using the [Conditional("DEBUG")] attribute for printing debug information in C#. The best approach depends on your specific needs and preferences.


