using System;

namespace Dp
{
    public interface ICar
    {
         int wheels { get; set; }
         string color { get; set; }
         string Company { get; set; }
         void CommonTaskLikeAssembling();
    }

    public abstract class Maker: ICar
    {
        public int wheels { get; set; } 
        public string color { get; set; } 
        public string Company { get; set; }
        public abstract void CommonTaskLikeAssembling();
        public ICar FinishCarMaking()
        {
            ICar _car = this;
            _car.color = getColor();
            _car.Company = getCompany();
            _car.CommonTaskLikeAssembling();
            return _car;
        }
        protected abstract string getColor();
        protected abstract string getCompany();
        public override string ToString()
        {
            return $"{Company} car with {color} color."; 
        }
    }

    public class CartFactoryMethod
    {
        private Maker _maker;
        public CartFactoryMethod(Maker maker)
        {
            _maker = maker;
        }
        public ICar GetFinishedCar() {
            return _maker.FinishCarMaking();
        }
    }
    public class BMWCarMaker : Maker
    {
        protected override string getColor()
        {
            return "white";
        }
        public override void CommonTaskLikeAssembling()
        {
            Console.WriteLine("CommonTaskLikeAssembling BMW ");
        }
        protected override string getCompany()
        {
            return "BMW";
        }
    }
    public class HondaCarMaker : Maker
    {
        protected override string getColor()
        {
            return "black";
        }
        public override void CommonTaskLikeAssembling()
        {
            Console.WriteLine("CommonTaskLikeAssembling Honda");
        }
        protected override string getCompany()
        {
            return "Honda";
        }
    }
}
