namespace DesignPatterns.FactoryPattern
{
    internal abstract class PizzaStore
    {
        public void OrderPizza(string type)
        {
            //Factory Function
            Pizza pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
        }
        public abstract Pizza CreatePizza(string type);
    }
}
