namespace DesignPatterns.DecoratorPattern.Condiments
{
    internal class Whip : CondimentDecorator
    {
        Beverage beverage;
        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override string GetDescribtion() => beverage.GetDescribtion() + ", Whip";
        public override double GetCost() => beverage.GetCost() + .25;

    }
}
