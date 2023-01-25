namespace DesignPatterns.CompositePattern.Interfaces
{
    internal interface IMenuItem:IMenuComponent
    {
        double getPrice();
        bool isVegetarian();
    }
}
