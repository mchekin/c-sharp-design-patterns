using GangOfFour.Behavioral.Command.Commands;

namespace GangOfFour.Behavioral.Command
{
    public class Switch
    {
        private readonly ICommand _onCommand;
        private readonly ICommand _offCommand;

        public Switch(ICommand onCommand, ICommand offCommand)
        {
            _onCommand = onCommand;
            _offCommand = offCommand;
        }

        public void TurnOn()
        {
            _onCommand.Execute();
        }

        public void TurnOff()
        {
            _offCommand.Execute();
        }
    }
}