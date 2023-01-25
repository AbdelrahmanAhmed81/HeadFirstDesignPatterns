using DesignPatterns.FactoryPattern.Ingredients;

namespace DesignPatterns.FactoryPattern
{
    internal abstract class Pizza
    {
        //public abstract string Name { get; set; }
        //public abstract string Sauce { get; set; }
        //public abstract string Dough { get; set; }
        //public abstract string[] Toppings { get; set; }
        public string name;
        public Dough dough;
        public Sauce sauce;
        public Cheese cheese;
        public Veggie[] veggies;

        public abstract void Prepare();

        //public virtual void Prepare()
        //{
        //    Console.WriteLine("Preparing " + Name);
        //    Console.WriteLine("Tossing dough...");
        //    Console.WriteLine("Adding sauce...");
        //    Console.WriteLine("Adding toppings: ");
        //    for (int i = 0 ; i < Toppings.Length ; i++)
        //    {
        //        Console.WriteLine(" " + Toppings[i]);
        //    }
        //}
        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }
        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }
        public virtual void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }
    }
}
