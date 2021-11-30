using System;
using System.Linq;

namespace DesignPatterns.Structural.Adapter;

public class ClassEmployeeAdapter : RecordServer, IEmployeeService
{
    public Employee GetEmployee(int id)
    {
        var employee = Employees.FirstOrDefault(x => x.Id == id);
        if (employee == null)
            throw new Exception($"Employee can't be found with id: {id}");

        return employee;
    }
}
