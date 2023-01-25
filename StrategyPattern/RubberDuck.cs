using DesignPatterns.StrategyPattern.Implementations;

namespace DesignPatterns.StrategyPattern
{
    //not flying but squeaking
    internal class RubberDuck : Duck
    {
        public RubberDuck()
        {
            flyBehavior = new NotFlying();
            quackBehavior = new SqueakBehavior();
        }
        public override void Display()
        {
            Console.WriteLine("Rubber Duck");
        }
        //old way
        //public override void Fly()
        //{
            
        //}

        //public override void Quack()
        //{
        //    Console.WriteLine("Squeak");
        //}
    }
}
