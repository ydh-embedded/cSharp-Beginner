## Vererbung
  - Code-Redundanz vermeiden
  - Code-Redundanz reduzieren
  - Erweiterung bestehender Klasse
  - Override einer Methode z.B. ToString Methode der "System.Object"
  - Logik erweitern
  - geerbte Methoden ersetzen
  - "Ist - Ein" Beziehung muss eingehalten werden! z.B. fly des Vogels und Pinguin
  - Polymorphie
### Generalisierung
  
- Das Tier ist eine Generalisierung von Vögeln und Pinguine

### Spezialisierung

- Pinguine sind Spezialisierung der Tiere
  - wenn eine Spezialisierung eine Invalid Exception wirft,
  dann handelt es sich meist um einen logischen Programming-Failure

### Override 

-   public override ToString()


### Virtual 

-   ist eine class als virtual definiert 
- - Unterklassen dürfen überschrieben werden

### Polymorphie

-   die Möglichkeit allgemeine Methode zu definieren
  - Polymorphismus in C # ist die Fähigkeit eines Objekts,
    viele Formen anzunehmen.
  - Die häufigste Verwendung von Polymorphismus, ist das Überschreiben von Methoden.
  - Auf diese Weise kann eine abgeleitete Klasse eine andere Implementierung einer Methode bereitstellen, die bereits von der Basisklasse bereitgestellt wird.

````csharp
using System;

class Polygon
{
    // method to render a shape
    public virtual void render()
    {
        Console.WriteLine("Rendering Polygon...");
    }
}

class Square : Polygon
{
    // overriding render() method 
    public override void render()
    {
        Console.WriteLine("Rendering Square...");
    }
}

class myProgram
{
    public static void Main()
    {
        // obj1 is the object of Polygon class
        Polygon obj1 = new Polygon();

        // calls render() method of Polygon Superclass 
        obj1.render();

        // here, obj1 is the object of derived class Square 
        obj1 = new Square();

        // calls render() method of derived class Square
        obj1.render();
    }
}
````

### Basis class

-   ist die Oberklasse und der Ursprung der class

````csharp
public class Animal
{
    public string Name { get; set; }

    public Animal(string name)
    {
        Name = name;
    }

    public virtual void MakeSound()
    {
        Console.WriteLine("The animal makes a sound.");
    }
}

public class Dog : Animal
{
    public Dog(string name) : base(name)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine("The dog barks.");
    }
}
````

### protected class

-   nur Nachfahren dürfen darauf zugreifen

````csharp
public class Animal
{
    protected int Age { get; set; }

    public Animal(int age)
    {
        Age = age;
    }
}

public class Dog : Animal
{
    public Dog(int age) : base(age)
    {
    }

    public void PrintAge()
    {
        Console.WriteLine($"The dog is {Age} years old.");
    }
}
````

### static - binding

-   zum Start bzw. zur Übersetzung werden Werte festgelegt
  - es wird immer der Datentyp heran gezogen

````csharp
public class Calculator
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int result = Calculator.Add(2, 3);
        Console.WriteLine(result);
    }
}
``
````

### dynamic - binding

-   Werte werden während der Laufzeit geschrieben

````csharp
public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("The animal makes a sound.");
    }
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("The dog barks.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal animal = new Dog(); // The actual object is a Dog, but the reference variable is of type Animal

        // Static binding
        animal.MakeSound(); // Output: The animal makes a sound.

        // Dynamic binding
        ((Dog)animal).MakeSound(); // Output: The dog barks.
    }
}
````

## print stream


## modul viewer controller      
                                    // Verantwortlichkeiten trennen separat ausgaben 