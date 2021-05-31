using Mchekin.DesignPatterns.GangOfFour.Behavioral.Strategy.Strategies;

namespace Mchekin.DesignPatterns.GangOfFour.Behavioral.Strategy.Entities
{
    public class SalaryService
    {
        private readonly MaximumTaxStrategyInterface _taxStrategy;

        public SalaryService(MaximumTaxStrategyInterface taxStrategy)
        {
            this._taxStrategy = taxStrategy;
        }

        public double applyMaximumIncomeTax(double grossSalary)
        {
            return this._taxStrategy.Apply(grossSalary);
        }
    }
}
