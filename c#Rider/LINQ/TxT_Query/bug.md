# 💩 bug

````xml

<TxT_Query>\Person.cs (1 error)
  <TxT_Query>\Person.cs:158 Cannot resolve symbol 'BirthDate'
  
<TxT_Query>\SVM.cs (2 errors)
  <TxT_Query>\SVM.cs:568 Cannot resolve symbol 'Age'

````

`````csharp

namespace TxT_Query;

using static TxT_Query.Person;

public class SVM
{
    static void Main(string[] args)
    {
        PersonGenerator generator = new();
        generator.AddFirstNames(File.ReadAllLines(@".\firstname.txt"));
        generator.AddLastNames(File.ReadAllLines(@".\lastname.txt"));

        List<Person> people = [];
        for (int i = 1; i <= 20; i++)
        {
            Person person = generator.Generate();
        }

        List<Person> seniors = people.Where(p => p.Age >= 65).ToList();
        List<Person> children = people.Where(p => p.Age < 14).ToList();

        Console.WriteLine("" + 
                          "Senioren:" + 
                          string.Join("\n", seniors));
        
        Console.WriteLine("" + 
                          "Kids:" + 
                          string.Join("\n", children));
    }
}

class PersonGenerator
{
    private List<string> firstNames;
    private List<string> lastNames;
    private List<Gender> genders;

    private static readonly Random randomizer = new();

    public PersonGenerator()
    {
        firstNames = [];
        lastNames = [];
        genders = ((Gender[])Enum.GetValues(typeof(Gender))).ToList();
    }

    public void AddFirstNames(IEnumerable<string> names)
    {
        firstNames.AddRange(names);
    }

    public void AddLastNames(IEnumerable<string> names)
    {
        lastNames.AddRange(names);
    }

    public Person Generate()
    {
        string firstName = firstNames[randomizer.Next(firstNames.Count)];
        string lastName = lastNames[randomizer.Next(lastNames.Count)];
        Gender gender = genders[randomizer.Next(genders.Count)];
        int year = randomizer.Next(1900, 2020 + 1);
        int month = randomizer.Next(1, 12 + 1);
        int day = randomizer.Next(1, DateTime.DaysInMonth(year, month) + 1);

        return new Person($"{firstName} {lastName}", new DateTime(year, month, day), gender);
    }
}
`````

`````csharp

namespace TxT_Query;

// partial record
public partial record Person(string Name, DateTime BirthDate, Gender Gender);
{
    public int Age => (DateTime.Now - BirthDate).Days / 365;
}

`````


# 🦊 Lösung

## Error Fixing

-   The error messages indicate that the symbols BirthDate and Age cannot be resolved. This is because the Person class is a partial record, and the properties BirthDate and Age are not accessible from the SVM class.

````csharp

// SVM.cs
namespace TxT_Query;

using static TxT_Query.Person;

public class SVM
{
    static void Main(string[] args)
    {
        PersonGenerator generator = new();
        generator.AddFirstNames(File.ReadAllLines(@".\firstname.txt"));
        generator.AddLastNames(File.ReadAllLines(@".\lastname.txt"));

        List<Person> people = new List<Person>(); // Initialize the list
        for (int i = 1; i <= 20; i++)
        {
            people.Add(generator.Generate()); // Add person to the list
        }

        List<Person> seniors = people.Where(p => p.Age >= 65).ToList();
        List<Person> children = people.Where(p => p.Age < 14).ToList();

        Console.WriteLine("Seniors:\n" + string.Join("\n", seniors.Select(p => p.Name)));
        Console.WriteLine("Kids:\n" + string.Join("\n", children.Select(p => p.Name)));
    }
}


````

````csharp


// Person.cs
namespace TxT_Query;

public enum Gender { Male, Female }

public partial record Person(string Name, DateTime BirthDate, Gender Gender)
{
    public int Age => (DateTime.Now - BirthDate).Days / 365;
}
    

````

## Additional Suggestions

    -   Consider using a more robust way to calculate the age,
        such as using the DateTime.Today property and taking into account the person's birthdate and the current date.
    -   You may want to add error handling for cases where the firstname.txt
        or lastname.txt files are not found or cannot be read.
    -   Consider using a more efficient data structure, such as a HashSet<string>,
        to store the first names and last names.
    -   You may want to add more functionality to the PersonGenerator class,
        such as generating random addresses or phone numbers.

## Changes

    -  Initialized the people list in SVM class.
    -  Added the generated Person object to the people list in the loop.
    -  Changed the Console.WriteLine statements to use Select to project the Name property of each Person object.
    -  Removed the unnecessary using static directive.
    -  Moved the Gender enum to the Person.cs file, as it is closely related to the Person class.
