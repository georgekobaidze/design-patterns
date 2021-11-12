using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Solid.DependencyInversion.Good
{
    public class OvertimeSalaryCalculator : ISalaryCalculator
    {
        public decimal CalculateSalary(int hours, decimal rate)
        {
            return hours * rate * 2;
        }
    }
}
