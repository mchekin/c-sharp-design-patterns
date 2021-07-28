using GangOfFour.Behavioral.Strategy.Strategies;

namespace GangOfFour.Behavioral.Strategy.Services
{
    public class SalaryService
    {
        private readonly IMaximumTaxStrategy _taxStrategy;

        public SalaryService(IMaximumTaxStrategy taxStrategy)
        {
            this._taxStrategy = taxStrategy;
        }

        public double ApplyMaximumIncomeTax(double grossSalary)
        {
            return this._taxStrategy.Apply(grossSalary);
        }
    }
}
