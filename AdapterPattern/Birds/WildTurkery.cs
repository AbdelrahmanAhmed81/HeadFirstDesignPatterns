using DesignPatterns.AdapterPattern.Interfaces;

namespace DesignPatterns.AdapterPattern.Birds
{
    internal class WildTurkery : ITurkey
    {
        public void Fly()
        {
            Console.WriteLine("Wild Turkery Flying");
        }

        public void Gobble()
        {
            Console.WriteLine("Gobble gobble");
        }
    }
}
