using DesignPatterns.StrategyPattern.Interfaces;

namespace DesignPatterns.StrategyPattern.Implementations
{
    internal class FlyBehavior : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Duck Flying");
        }
    }
}
