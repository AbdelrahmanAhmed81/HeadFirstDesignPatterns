using System.Collections;

namespace DesignPatterns.CompositePattern
{
    internal class Menu : MenuComponent
    {
        ArrayList menuComponents = new ArrayList();
        string name;
        string description;
        public Menu(string name , string description)
        {
            this.name = name;
            this.description = description;
        }
        public override void add(MenuComponent menuComponent)
        {
            menuComponents.Add(menuComponent);
        }
        public override void remove(MenuComponent menuComponent)
        {
            menuComponents.Remove(menuComponent);
        }
        public override MenuComponent getChild(int i)
        {
            return (MenuComponent) menuComponents[i];
        }
        public override string getName()
        {
            return name;
        }
        public override string getDescription()
        {
            return description;
        }
        public override void print()
        {
            Console.Write("\n" + getName());
            Console.WriteLine(", " + getDescription());
            Console.WriteLine("---------------------");

            //var iterator = menuComponents.GetEnumerator();
            //while (iterator.MoveNext())
            //{
            //    ((MenuComponent) iterator.Current).print();
            //}
            //Equieivant to
            foreach (var component in menuComponents)
            {
                ((MenuComponent) component).print();
            }
        }
    }
}
