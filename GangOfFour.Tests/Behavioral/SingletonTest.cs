using GangOfFour.Behavioral.Singleton;
using Xunit;

namespace GangOfFour.Tests.Behavioral
{
    public class SingletonTest
    {
        [Fact]
        public void MaxGermanyTax()
        {
            var singleton1 = Singleton.Instance;
            var singleton2 = Singleton.Instance;

            Assert.NotNull(singleton1);
            Assert.IsType<Singleton>(singleton1);
            Assert.Same(singleton1,singleton2);
        }
    }
}
