using DesignPatterns.FactoryPattern.Ingredients;

namespace DesignPatterns.FactoryPattern
{
    internal interface IPizzaIngredientFactory
    {
        public Dough createDough();
        public Sauce createSauce();
        public Cheese createCheese();
        public Veggie[] createVeggies();
    }
}
