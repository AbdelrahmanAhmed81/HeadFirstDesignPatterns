namespace DesignPatterns.TemplatePattern
{
    internal abstract class CaffeineBeverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            if (WantCondimentsHook())
                AddCondiments();
        }
        protected void BoilWater()
        {
            Console.WriteLine("Boiling Water");
        }
        abstract protected void Brew();
        protected void PourInCup()
        {
            Console.WriteLine("Pouring in a Cup");
        }
        abstract protected void AddCondiments();
        protected virtual bool WantCondimentsHook() => true;

    }
}
