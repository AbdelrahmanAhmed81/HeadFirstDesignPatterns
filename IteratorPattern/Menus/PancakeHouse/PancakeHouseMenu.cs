using System.Collections;

namespace DesignPatterns.IteratorPattern.Menus.PancakeHouse
{
    internal class PancakeHouseMenu : IMenu
    {
        ArrayList menuItems = new ArrayList();
        public string MenuName { get; init; } = "BREAKFAST";
        public PancakeHouseMenu()
        {
            addItem("K & B’s Pancake Breakfast" , "Pancakes with scrambled eggs , and toast" , true , 2.99);
            addItem("Regular Pancake Breakfast" , "Pancakes with fried eggs , sausage" , false , 2.99);
            addItem("Blueberry Pancakes" , "Pancakes made with fresh blueberries" , true , 3.49);
            addItem("Waffles" , "Waffles , with your choice of blueberries or strawberries" , true , 3.59);
        }

        public void addItem(string name , string description , bool vegetarian , double price)
        {
            MenuItem menuItem = new MenuItem(name , description , vegetarian , price);
            menuItems.Add(menuItem);
        }
        //public ArrayList getMenuItems()
        //{
        //    return menuItems;
        //}

        //public IIterator GetIterator()
        //{
        //    return new PancakeHouseMenuIterator(menuItems);
        //}
        public IEnumerator GetEnumerator()
        {
            return menuItems.GetEnumerator();
            //return new PancakeHouseMenuIterator(menuItems);
        }
    }
}
