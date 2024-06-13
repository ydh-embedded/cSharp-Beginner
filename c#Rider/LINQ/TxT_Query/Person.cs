namespace TxT_Query;

// partial record
public partial record Person(string Name, DateTime BirthDate, Gender Gender)
{
    public int Age => (DateTime.Now - BirthDate).Days / 365;
}