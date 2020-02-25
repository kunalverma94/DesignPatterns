namespace Dp
{
    public sealed class LockSingleton
    {
        private static int t = 0;
        private static  LockSingleton _instance;
        private static readonly object _lock = new object();
        public static LockSingleton Instance
        {
            get
            {
                //double check locking
                if (_instance == null)
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            t++;
                            _instance = new LockSingleton();
                        }
                    }

                return _instance;
            }
        }
        public void Print() => System.Console.WriteLine($"this.ToString() {t}");
        private LockSingleton()
        {

        }
    }
}
