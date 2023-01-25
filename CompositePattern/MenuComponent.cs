namespace DesignPatterns.CompositePattern
{
    internal abstract class MenuComponent
    {
        //Functions for Composite Nodes (Menus)
        public virtual void add(MenuComponent menuComponent)
        {
            throw new InvalidOperationException();
        }
        public virtual void remove(MenuComponent menuComponent)
        {
            throw new InvalidOperationException();
        }
        public virtual MenuComponent getChild(int i)
        {
            throw new InvalidOperationException();
        }

        //Functions for Leaf Nodes (Menu Items)
        public virtual double getPrice()
        {
            throw new InvalidOperationException();
        }
        public virtual bool isVegetarian()
        {
            throw new InvalidOperationException();
        }

        //Function for Both
        public virtual string getName()
        {
            throw new InvalidOperationException();
        }
        public virtual string getDescription()
        {
            throw new InvalidOperationException();
        }
        public virtual void print()
        {
            throw new InvalidOperationException();
        }
    }
}
