namespace Dp
{
    public sealed class StaticSingleton
    {
        private static int t = 0;

        static StaticSingleton()
        {
            if (Instance == null)
            {
                t++;
                Instance = new StaticSingleton();
            }
        }
        public static readonly StaticSingleton Instance;
        public void Print() => System.Console.WriteLine($"this.ToString() {t}");


        private StaticSingleton()
        {

        }
    }
}
