namespace DesignPatterns.FactoryPattern.Pizzas
{
    internal class CheesePizza : Pizza
    {
        IPizzaIngredientFactory _factory;
        public CheesePizza(IPizzaIngredientFactory factory)
        {
            _factory = factory;
        }
        public override void Prepare()
        {
            Console.WriteLine("Preparing " + name);
            _factory.createDough();
            _factory.createSauce();
            _factory.createCheese();
        }
    }
}
