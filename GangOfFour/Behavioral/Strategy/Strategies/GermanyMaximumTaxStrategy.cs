using System;

namespace Mchekin.DesignPatterns.GangOfFour.Behavioral.Strategy.Strategies
{
    public class GermanyMaximumTaxStrategy : MaximumTaxStrategyInterface
    {
        public double Apply(double beforeTax)
        {
            return Math.Round(beforeTax * 0.55, 2);
        }
    }
}
