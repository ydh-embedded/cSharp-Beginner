namespace OOP_Aggregation;

public class Department
{
    private List<Employee> _employees = new List<Employee>();

    public void AddEmployee(Employee employee)
    {
        this._employees.Add(employee);
    }

    public void RemoveEmployee(Employee employee)
    {
        this._employees.Remove(employee);
    }

    public void PrintDepartmentInfo()
    {
        Console.WriteLine("Department Info:");
        foreach (var employee in this._employees)
        {
            Console.WriteLine($"  {employee.Name} - {employee.Role}");
        }
    }
}

public class Employee
{
    public string Name { get; set; }
    public string Role { get; set; }

    public Employee(string name, string role)
    {
        Name = name;
        Role = role;
    }
}
