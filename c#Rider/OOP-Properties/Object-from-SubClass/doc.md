

# Object-from-SubClass

````csharp

    public LazyThreadSafetyMode(Material material = Material.Wolfram,
           int power = 5, Current current = Current.Direct)
        : base(power, current, isConnected: false)
    {
        this.Material;
    }
````