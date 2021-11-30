using System;
using System.Linq;

namespace DesignPatterns.Structural.Adapter;

//Adapter
public class ObjectEmployeeAdapter : IEmployeeService
{
    private readonly RecordServer _recordServer;

    public ObjectEmployeeAdapter(RecordServer recordServer)
    {
        _recordServer = recordServer;
    }

    public Employee GetEmployee(int id)
    {
        var employee = _recordServer.Employees.FirstOrDefault(x => x.Id == id);
        if (employee == null)
            throw new Exception($"Employee can't be found with id: {id}");

        return employee;
    }
}
