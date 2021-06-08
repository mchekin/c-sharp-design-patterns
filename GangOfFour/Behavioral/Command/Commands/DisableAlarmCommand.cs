namespace GangOfFour.Behavioral.Command.Commands
{
    public class DisableAlarmCommand : ICommand
    {
        private readonly Alarm _alarm;

        public DisableAlarmCommand(Alarm alarm)
        {
            _alarm = alarm;
        }

        public void Execute()
        {
            _alarm.Off();
        }
    }
}