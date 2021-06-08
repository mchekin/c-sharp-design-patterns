using GangOfFour.Behavioral.Command;
using GangOfFour.Behavioral.Command.Commands;
using Xunit;

namespace GangOfFour.Tests.Behavioral
{
    public class CommandTest
    {
        [Fact]
        public void TurnOn()
        {
            var receiver = new Alarm(false);
            
            var invoker = new Switch(
                new EnableAlarmCommand(receiver),
                new DisableAlarmCommand(receiver)
            );
            
            invoker.TurnOn();

            Assert.True(receiver.IsOn());
        }

        [Fact]
        public void TurnOff()
        {
            var receiver = new Alarm(true);
            
            var invoker = new Switch(
                new EnableAlarmCommand(receiver),
                new DisableAlarmCommand(receiver)
            );
            
            invoker.TurnOff();

            Assert.False(receiver.IsOn());
        }

        [Fact]
        public void TurnOnAndOff()
        {
            var receiver = new Alarm(false);
            
            var invoker = new Switch(
                new EnableAlarmCommand(receiver),
                new DisableAlarmCommand(receiver)
            );
            
            invoker.TurnOn();
            invoker.TurnOff();
            invoker.TurnOn();

            Assert.True(receiver.IsOn());
        }
    }
}
