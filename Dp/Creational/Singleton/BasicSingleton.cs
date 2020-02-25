namespace Dp
{
    public sealed class BasicSingleton
    {
        private static int t = 0;
        private static BasicSingleton _instance;
        public static BasicSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    t++;
                    _instance = new BasicSingleton();
                }
                return _instance;
            }
        }
        public void Print() => System.Console.WriteLine($"this.ToString() {t}");
        private BasicSingleton()
        {

        }
    }
}
