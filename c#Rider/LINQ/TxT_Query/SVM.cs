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