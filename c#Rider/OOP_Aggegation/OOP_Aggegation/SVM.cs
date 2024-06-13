namespace OOP_Aggregation;

public class SVM
{
    static void Main(string[] args)
    {
        Department salesDepartment = new Department();
        salesDepartment.AddEmployee(new Employee("John Doe", "Sales Manager"));
        salesDepartment.AddEmployee(new Employee("Jane Smith", "Sales Representative"));
        salesDepartment.AddEmployee(new Employee("Bob Johnson", "Sales Engineer"));

        salesDepartment.PrintDepartmentInfo();
    }
}