using GangOfFour.Behavioral.Strategy.Services;
using GangOfFour.Behavioral.Strategy.Strategies;
using Xunit;

namespace GangOfFour.Tests.Behavioral
{
    public class StrategyTest
    {
        [Fact]
        public void MaxGermanyTax()
        {
            var service = new SalaryService(new GermanyMaximumTaxStrategy());

            Assert.Equal(55, service.ApplyMaximumIncomeTax(100));
        }

        [Fact]
        public void MaxUkTax()
        {
            var service = new SalaryService(new UkMaximumTaxStrategy());

            Assert.Equal(61.9, service.ApplyMaximumIncomeTax(100));
        }
    }
}
