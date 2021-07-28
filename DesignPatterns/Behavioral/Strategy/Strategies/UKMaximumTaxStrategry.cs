using System;

namespace GangOfFour.Behavioral.Strategy.Strategies
{
    public class UkMaximumTaxStrategy : IMaximumTaxStrategy
    {
        public double Apply(double beforeTax)
        {
            return Math.Round(beforeTax * 0.619, 2);
        }
    }
}
