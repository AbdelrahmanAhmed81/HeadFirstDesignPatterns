namespace DesignPatterns.CompositePattern.Interfaces
{
    internal interface IMenu : IMenuComponent
    {
        void add(IMenuComponent menuComponent);
        void remove(IMenuComponent menuComponent);
        IMenuComponent getChild(int i);
    }
}
