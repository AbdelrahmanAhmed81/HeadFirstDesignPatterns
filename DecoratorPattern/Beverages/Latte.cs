namespace DesignPatterns.DecoratorPattern.Beverages
{
    internal class Latte : Beverage
    {
        public Latte()
        {
            describtion = "Latte";
        }
        public override double GetCost() => .89;
    }
}
