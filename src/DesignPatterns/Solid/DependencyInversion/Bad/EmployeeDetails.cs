namespace DesignPatterns.Solid.DependencyInversion.Bad;

public class EmployeeDetails
{
    public int WorkingHours { get; set; }
    public decimal HourlyRate { get; set; }

    public decimal CalculateSalary() => new SalaryCalculator().CalculateSalary(WorkingHours, HourlyRate);
}
