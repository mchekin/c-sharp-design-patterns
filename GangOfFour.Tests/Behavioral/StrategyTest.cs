using Mchekin.DesignPatterns.GangOfFour.Behavioral.Strategy.Entities;
using Mchekin.DesignPatterns.GangOfFour.Behavioral.Strategy.Strategies;
using System;
using Xunit;

namespace Mchekin.DesignPatterns.GangOfFour.Tests
{
    public class StrategyTest
    {
        [Fact]
        public void TestMaxGermanyTax()
        {
            var service = new SalaryService(new GermanyMaximumTaxStrategy());

            Assert.Equal(55, service.applyMaximumIncomeTax(100));
        }

        [Fact]
        public void TestMaxUKTax()
        {
            var service = new SalaryService(new UKMaximumTaxStrategy());

            Assert.Equal(61.9, service.applyMaximumIncomeTax(100));
        }
    }
}
