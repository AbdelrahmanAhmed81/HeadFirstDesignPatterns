using DesignPatterns.StrategyPattern.Interfaces;

namespace DesignPatterns.StrategyPattern.Implementations
{
    internal class SqueakBehavior : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Duck Squeaking");
        }
    }
}
