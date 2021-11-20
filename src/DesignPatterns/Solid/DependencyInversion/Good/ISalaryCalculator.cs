namespace DesignPatterns.Solid.DependencyInversion.Good;

public interface ISalaryCalculator
{
    decimal CalculateSalary(int hours, decimal rate);
}
