namespace DesignPatterns.FactoryPattern.Ingredients.IngredientsFactories
{
    internal class ChicagoPizzaIngredientsFactory : IPizzaIngredientFactory
    {
        public Cheese createCheese()
        {
            return new MozarillaCheese();
        }

        public Dough createDough()
        {
            return new ExtraThickCrustDough();
        }

        public Sauce createSauce()
        {
            return new MarianaSauce();
        }

        public Veggie[] createVeggies()
        {
            return new Veggie[] { new Onion() , new Olive() };
        }
    }
}
