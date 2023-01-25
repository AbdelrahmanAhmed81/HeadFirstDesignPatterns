using DesignPatterns.AdapterPattern.Interfaces;

namespace DesignPatterns.AdapterPattern.Adapters
{
    internal class TurkeryAdapter : IDuck
    {
        ITurkey turkey;
        public TurkeryAdapter(ITurkey _turkey)
        {
            turkey = _turkey;
        }
        public void Fly()
        {
            for (int i = 0 ; i < 5 ; i++)
            {
                turkey.Fly();
            }
        }

        public void Quack()
        {
            turkey.Gobble();
        }
    }
}
