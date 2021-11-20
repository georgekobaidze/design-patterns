namespace DesignPatterns.Solid.DependencyInversion.Good;

public class OvertimeSalaryCalculator : ISalaryCalculator
{
    public decimal CalculateSalary(int hours, decimal rate) => hours * rate * 2;
}
