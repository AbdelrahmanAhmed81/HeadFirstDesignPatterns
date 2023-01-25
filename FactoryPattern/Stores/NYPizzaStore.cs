//using DesignPatterns.FactoryPattern.Pizzas.NYStyle;

using DesignPatterns.FactoryPattern.Ingredients.IngredientsFactories;
using DesignPatterns.FactoryPattern.Pizzas;

namespace DesignPatterns.FactoryPattern.Stores
{
    internal class NYPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            switch (type)
            {
                case "cheese":
                {
                    //return new NYStyleCheesePizza();
                    pizza = new CheesePizza(new NYPizzaIngredientsFactory());
                    pizza.name = "NY Style Sauce and Cheese Pizza";
                    break;
                }
            }
            return pizza;
        }
    }
}
