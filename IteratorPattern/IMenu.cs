using System.Collections;

namespace DesignPatterns.IteratorPattern
{
    internal interface IMenu
    {
        string MenuName { get; init; }
        void addItem(string name , string description , bool vegetarian , double price);
        IEnumerator GetEnumerator();
        //IIterator GetIterator();
    }
}
