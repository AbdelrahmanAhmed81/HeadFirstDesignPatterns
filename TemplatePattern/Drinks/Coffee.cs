namespace DesignPatterns.TemplatePattern.Drinks
{
    internal class Coffee : CaffeineBeverage
    {
        protected override void AddCondiments()
        {
            Console.WriteLine("add sugar and milk");
        }

        protected override void Brew()
        {
            Console.WriteLine("add coffee grains");
        }
    }
}
