namespace DesignPatterns.Solid.DependencyInversion.Good
{
    public class EmployeeDetails
    {
        private readonly ISalaryCalculator _salaryCalculator;
        public EmployeeDetails(ISalaryCalculator salaryCalculator)
        {
            _salaryCalculator = salaryCalculator;
        }

        public int WorkingHours { get; set; }
        public decimal HourlyRate { get; set; }

        public decimal GetSalary() => _salaryCalculator.CalculateSalary(WorkingHours, HourlyRate);
    }
}
