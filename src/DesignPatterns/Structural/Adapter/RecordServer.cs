using System.Collections.Generic;

namespace DesignPatterns.Structural.Adapter;

// Adaptee
public class RecordServer
{
    private List<Employee> _employees;

    public List<Employee> Employees { get { return _employees; } }

    public RecordServer()
    {
        InitializeEmployees();
    }

    private void InitializeEmployees() => _employees = new List<Employee>
        {
            new Employee(1, "Freddy", "Callahan"),
            new Employee(2, "Alan", "Morrison"),
            new Employee(3, "Eugene", "Walters")
        };
}
