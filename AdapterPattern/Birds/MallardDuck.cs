using DesignPatterns.AdapterPattern.Interfaces;

namespace DesignPatterns.AdapterPattern.Birds
{
    internal class MallardDuck : IDuck
    {
        public void Fly()
        {
            Console.WriteLine("I'm Flying");
        }

        public void Quack()
        {
            Console.WriteLine("Mallard Duck Quacking");
        }
    }
}
