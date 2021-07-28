namespace GangOfFour.Behavioral.Command
{
    public class Alarm
    {
        private bool _status;

        public Alarm(bool status)
        {
            _status = status;
        }

        public void Off()
        {
            _status = false;
        }

        public void On()
        {
            _status = true;
        }
        
        public bool IsOn()
        {
            return _status;
        }
    }
}