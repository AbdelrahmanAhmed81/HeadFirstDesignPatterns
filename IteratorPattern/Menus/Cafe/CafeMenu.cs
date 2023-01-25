using System.Collections;

namespace DesignPatterns.IteratorPattern.Menus.Cafe
{
    internal class CafeMenu : IMenu
    {
        Hashtable menuItems = new Hashtable();
        public string MenuName { get; init; } = "CAFE`";
        public CafeMenu()
        {
            addItem("Veggie Burger and Air Fries" , "Veggie burger on a whole wheat bun , lettuce , tomato , and fries" , true , 3.99);
            addItem("Soup of the day" , "A cup of the soup of the day , with a side salad" , false , 3.69);
            addItem("Burrito" , "A large burrito , with whole pinto beans , salsa , guacamole" , true , 4.29);
        }


        public void addItem(string name , string description ,bool vegetarian , double price)
        {
            MenuItem menuItem = new MenuItem(name , description , vegetarian , price);
            menuItems.Add(menuItem.name, menuItem);
        }

        public IEnumerator GetEnumerator()
        {
            return menuItems.Values.GetEnumerator();
            //return new CafeMenuIterator(menuItems);
        }
    }
}
