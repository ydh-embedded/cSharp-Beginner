
# Property

- Der compiler erstellt ein privates Feld und definiert private Getter und Setter Methoden für das Feld
- Zugriff geschieht jedoch über das Property
- Ein Property dessen Wert automatic erstellt wird



## nur lesbare Properties

## Readonly Properties

- In this example, we have a readonly field `dX` and a read-only property `X`.
- The property has a private setter, which means it can only be set within the class. However,
- the field `dX` is also marked as readonly, which means it can only be assigned a value during initialization or within the constructor of the class.
- This ensures that the value of `dX` cannot be changed after the object is created.

```csharp

    private readonly double dX;

    public double X
        {
            get => this.dX;
            private set
            {
                this.dX = value;
            }
    }
```

## Property Initializer

- In this example, we have a property `Y` with an initializer.
- The `init` accessor allows the property to be set only during object initialization 
- or when the property is created and passed as a parameter to a constructor. 
- After the object is created, the value of the property cannot be changed.

```csharp
public double Y { get; init; }
```