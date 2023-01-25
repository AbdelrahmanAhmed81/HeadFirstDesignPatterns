namespace DesignPatterns.DecoratorPattern.Condiments
{
    internal class Mocha : CondimentDecorator
    {
        Beverage beverage;
        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override string GetDescribtion() => beverage.GetDescribtion() + ", Mocha";
        public override double GetCost() => beverage.GetCost() + .50;

    }
}
