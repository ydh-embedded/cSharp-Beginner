using System;
namespace Tupel02;

[AttributeUsage(AttributeTargets.Class, Inherited = false)]
public class RunAttribute : Attribute
{
    public int Priority { get; }

    // Primary constructor
    public RunAttribute(int priority)
    {
        Priority = priority;
    }
}