namespace GangOfFour.Behavioral.Command.Commands
{
    public class EnableAlarmCommand: ICommand
    {
        private readonly Alarm _alarm;

        public EnableAlarmCommand(Alarm alarm)
        {
            _alarm = alarm;
        }
        
        public void Execute()
        {
            _alarm.On();
        }
    }
}