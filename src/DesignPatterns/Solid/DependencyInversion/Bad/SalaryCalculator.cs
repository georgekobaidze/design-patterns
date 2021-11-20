namespace DesignPatterns.Solid.DependencyInversion.Bad;

public class SalaryCalculator
{
    public decimal CalculateSalary(int hours, decimal rate) => hours * rate;
}
