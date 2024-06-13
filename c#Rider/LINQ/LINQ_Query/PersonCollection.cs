namespace LINQ_Query;

// Delegation type: a class that delegates its collection operations to an internal collection
public class PersonCollection
{
    private List<Person> _people = new List<Person>();

    public void Add(Person person)
    {
        _people.Add(person);
    }

    public void Remove(Person person)
    {
        _people.Remove(person);
    }

    public IEnumerator<Person> GetEnumerator()
    {
        return _people.GetEnumerator();
    }
}