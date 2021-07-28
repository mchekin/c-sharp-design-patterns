using System;

namespace GangOfFour.Behavioral.Strategy.Strategies
{
    public class GermanyMaximumTaxStrategy : IMaximumTaxStrategy
    {
        public double Apply(double beforeTax)
        {
            return Math.Round(beforeTax * 0.55, 2);
        }
    }
}
