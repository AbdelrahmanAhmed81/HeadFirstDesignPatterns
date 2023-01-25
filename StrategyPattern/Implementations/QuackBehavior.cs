using DesignPatterns.StrategyPattern.Interfaces;

namespace DesignPatterns.StrategyPattern.Implementations
{
    internal class QuackBehavior : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Duck Quacking");
        }
    }
}
