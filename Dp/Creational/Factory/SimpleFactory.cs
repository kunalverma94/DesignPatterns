using System;

namespace Dp
{

    public enum MathType
    {
        Numbers, Decimal, Iota
    }
    public interface IMath
    {
        public string Id { get; set; }

    }

    #region InternalImplementaions
    internal class Numbers : IMath
    {
        public string Id { get; set; } = "1";

    }
    internal class Decimal : IMath
    {
        public string Id { get; set; } = "1.1";
    }
    internal class Iota : IMath
    {
        public string Id { get; set; } = "i";
    }
    #endregion

    public static class SimpleFactory
    {
        public static IMath GetMath(MathType mathType)
        {
            switch (mathType)
            {
                case MathType.Numbers:
                return new Numbers();
                case MathType.Decimal:
                return new Decimal();
                case MathType.Iota:
                return new Iota();
                default:
                throw new Exception("INvalid IMath");
            }
        }
    }
}
