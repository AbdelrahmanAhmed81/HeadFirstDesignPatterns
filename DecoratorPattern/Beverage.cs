namespace DesignPatterns.DecoratorPattern
{
    internal abstract class Beverage
    {
        public string describtion = "unknown beverage";

        public virtual string GetDescribtion() => describtion;
        public abstract double GetCost();
    }
}
