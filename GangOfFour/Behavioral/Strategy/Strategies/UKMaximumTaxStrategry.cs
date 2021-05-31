using System;

namespace Mchekin.DesignPatterns.GangOfFour.Behavioral.Strategy.Strategies
{
    public class UKMaximumTaxStrategy : MaximumTaxStrategyInterface
    {
        public double Apply(double beforeTax)
        {
            return Math.Round(beforeTax * 0.619, 2);
        }
    }
}
