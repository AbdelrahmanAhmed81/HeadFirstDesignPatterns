using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryPattern.Ingredients.IngredientsFactories
{
    internal class NYPizzaIngredientsFactory : IPizzaIngredientFactory
    {
        public Cheese createCheese()
        {
            return new GratedReggianoCheese();
        }

        public Dough createDough()
        {
            return new ThinCrustDough();
        }

        public Sauce createSauce()
        {
            return new PlumTomatoSauce();
        }

        public Veggie[] createVeggies()
        {
            return new Veggie[] { new Olive() };
        }
    }
}
