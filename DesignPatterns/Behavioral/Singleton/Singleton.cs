namespace GangOfFour.Behavioral.Singleton
{
    public class Singleton
    {
        private static Singleton _instance;
        
        public static Singleton Instance
        {
            get { return _instance ??= new Singleton(); }
        }
        
        private Singleton() {}
    }
}