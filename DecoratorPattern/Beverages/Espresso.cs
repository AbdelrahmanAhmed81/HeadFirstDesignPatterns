namespace DesignPatterns.DecoratorPattern.Beverages
{
    internal class Espresso : Beverage
    {
        public Espresso()
        {
            describtion = "Espresso";
        }
        public override double GetCost() => 1.2;
    }
}
