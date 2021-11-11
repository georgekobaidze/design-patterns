namespace DesignPatterns.Solid.DependencyInversion.Bad
{
    public class EmployeeDetails
    {
        public int WorkingHours { get; set; }
        public decimal HourlyRate { get; set; }

        public decimal CalculateSalary() => new SalaryCalculator().CalculateSalary(WorkingHours, HourlyRate);
    }

    // As you see, the higher-level class - EmployeeDetails depends on lower-level SalaryCalculator class 
}
