using DesignPatterns.StrategyPattern.Interfaces;

namespace DesignPatterns.StrategyPattern.Implementations
{
    internal class NotQuacking : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("I can't quack");
        }
    }
}
