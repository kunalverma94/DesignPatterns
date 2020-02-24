using System;

namespace Dp
{
    //if initilisation require  very much resources
    public sealed class LazySingleton
    {
        private static int t = 0;
        //private readonly static Lazy<LazySingleton> _instance=new Lazy<LazySingleton>(()=> 
        //{
        //    return new LazySingleton();
        //},System.Threading.LazyThreadSafetyMode.ExecutionAndPublication);
        private readonly static Lazy<LazySingleton> _instance = new Lazy<LazySingleton>(() =>
        {
            return new LazySingleton();
        },true);
        public void Print() => System.Console.WriteLine($"this.ToString() {t}");
        private LazySingleton()
        {

        }
    }
}
