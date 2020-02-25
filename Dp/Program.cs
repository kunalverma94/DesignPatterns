using System.Threading;
using System.Threading.Tasks;

namespace Dp
{
    class Program
    {
        static void Main(string[] args)
        {
            HondaCarMaker maker = new HondaCarMaker();
            maker.FinishCarMaking();
            System.Console.WriteLine(maker.ToString());
        }

        private static void SimpleFactory()
        {
            IMath imath = Dp.SimpleFactory.GetMath(MathType.Iota);
            System.Console.WriteLine(imath.Id);
        }

        public static void BaiscSingletonFail()
        {
            Parallel.Invoke(() => BasicSingleton.Instance.Print(), () => (new Thread(() =>
            {
                BasicSingleton.Instance.Print();
            })).Start(), () => BasicSingleton.Instance.Print(), () => BasicSingleton.Instance.Print());
            Parallel.Invoke(() => BasicSingleton.Instance.Print(), () => (new Thread(() =>
            {
                BasicSingleton.Instance.Print();
            })).Start(), () => BasicSingleton.Instance.Print(), () => BasicSingleton.Instance.Print());
        }
        public static void LockSingletonThread()
        {

            //Extensive multithreading +Parallelinvoke
            Parallel.Invoke(() => LockSingleton.Instance.Print(), () => (new Thread(() =>
            {
                LockSingleton.Instance.Print();
            })).Start(), () => LockSingleton.Instance.Print(), () => LockSingleton.Instance.Print());
            Parallel.Invoke(() => LockSingleton.Instance.Print(), () => (new Thread(() =>
            {
                LockSingleton.Instance.Print();
            })).Start(), () => LockSingleton.Instance.Print(), () => LockSingleton.Instance.Print());
        }    
        public static void LazySingletonThread()
        {

            //Extensive multithreading +Parallelinvoke
            Parallel.Invoke(() => LockSingleton.Instance.Print(), () => (new Thread(() =>
            {
                LockSingleton.Instance.Print();
            })).Start(), () => LockSingleton.Instance.Print(), () => LockSingleton.Instance.Print());
            Parallel.Invoke(() => LockSingleton.Instance.Print(), () => (new Thread(() =>
            {
                LockSingleton.Instance.Print();
            })).Start(), () => LockSingleton.Instance.Print(), () => LockSingleton.Instance.Print());
        }
    }
}
