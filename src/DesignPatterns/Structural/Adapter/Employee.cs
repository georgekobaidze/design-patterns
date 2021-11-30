namespace DesignPatterns.Structural.Adapter;

public class Employee
{
    public Employee(int id, string firstName, string lastName)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
    }

    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public override string ToString() => $"Employee details:\nId: {Id}\nFull Name: {FirstName} {LastName}";
}
