using GangOfFour.Behavioral.Bridge.Abstraction;
using GangOfFour.Behavioral.Bridge.Implementer;
using Xunit;

namespace GangOfFour.Tests.Behavioral
{
    public class BridgeTest
    {
        [Fact]
        public void HumanWithSword()
        {
            var character = new Human(new Sword());

            Assert.Equal(27, character.GetAttackForce());
        }
        
        [Fact]
        public void HumanWithWarHammer()
        {
            var character = new Human(new WarHammer());

            Assert.Equal(52, character.GetAttackForce());
        }
        
        [Fact]
        public void OrcWithSword()
        {
            var character = new Orc(new Sword());

            Assert.Equal(30, character.GetAttackForce());
        }
        
        [Fact]
        public void OrcWithWarHammer()
        {
            var character = new Orc(new WarHammer());

            Assert.Equal(55, character.GetAttackForce());
        }
    }
}
