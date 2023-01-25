//using DesignPatterns.FactoryPattern.Pizzas.ChicagoStyle;

using DesignPatterns.FactoryPattern.Ingredients.IngredientsFactories;
using DesignPatterns.FactoryPattern.Pizzas;

namespace DesignPatterns.FactoryPattern.Stores
{
    internal class ChicagoPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            switch (type)
            {
                case "cheese":
                {
                    //return new ChicagoStyleCheesePizza();
                    pizza = new CheesePizza(new ChicagoPizzaIngredientsFactory());
                    pizza.name = "Chicago Style Deep Dish Cheese Pizza";
                    break;
                }
            }
            return pizza;
        }
    }
}
