namespace DesignPatterns.Solid.DependencyInversion.Good
{
    public class SalaryCalculator : ISalaryCalculator
    {
        public decimal CalculateSalary(int hours, decimal rate) => hours * rate;
    }
}
