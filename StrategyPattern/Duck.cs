using DesignPatterns.StrategyPattern.Interfaces;

namespace DesignPatterns.StrategyPattern
{
    internal abstract class Duck
    {
        public IFlyBehavior flyBehavior { private get; set; }
        public IQuackBehavior quackBehavior { private get; set; }
        //protected IFlyBehavior flyBehavior;
        public void Swim()
        {
            Console.WriteLine("Duck Is Swimming");
        }
        public abstract void Display();
        public void PerformFly()
        {
            flyBehavior.Fly();
        }
        public void PerformQuack()
        {
            quackBehavior.Quack();
        }

        //old way
        //public virtual void Quack()
        //{
        //    Console.WriteLine("Duck Quacking");
        //}
        //public virtual void Fly()
        //{
        //    Console.WriteLine("Duck Flying");
        //}
    }
}
