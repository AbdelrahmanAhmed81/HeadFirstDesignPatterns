using DesignPatterns.StrategyPattern.Implementations;

namespace DesignPatterns.StrategyPattern
{
    //not flying not quacking
    internal class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            flyBehavior = new NotFlying();
            quackBehavior = new NotQuacking();
        }
        public override void Display()
        {
            Console.WriteLine("Decoy Duck");
        }

        //old way
        //public override void Fly()
        //{

        //}

        //public override void Quack()
        //{

        //}
    }
}
