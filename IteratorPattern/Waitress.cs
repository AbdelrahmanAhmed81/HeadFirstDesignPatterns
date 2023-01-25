using System.Collections;

namespace DesignPatterns.IteratorPattern
{
    internal class Waitress
    {
        IMenu[] menus;
        public Waitress(params IMenu[] menus)
        {
            this.menus = menus;
        }
        public void printMenu()
        {
            //IIterator pancakeIterator = pancakeHouseMenu.GetIterator();
            //IIterator dinerIterator = dinerMenu.GetIterator();
            Console.WriteLine("MENU");
            foreach (var menu in menus)
            {
                Console.WriteLine(menu.MenuName);
                printIteratorItems(menu.GetEnumerator());
                Console.WriteLine("-----------------------------");
            }
        }
        private void printIteratorItems(IEnumerator enumerator)
        {
            while (enumerator.MoveNext())
            {
                var menuItem = enumerator.Current as MenuItem;
                Console.Write(menuItem.name + ", ");
                Console.Write(menuItem.price + " -- ");
                Console.WriteLine(menuItem.description);
            };
        }
        #region using our IIterator
        //private void printIteratorItems(IIterator iterator)
        //{
        //    while (iterator.hasNext())
        //    {
        //        MenuItem menuItem = iterator.next();
        //        Console.Write(menuItem.name + ", ");
        //        Console.Write(menuItem.price + " -- ");
        //        Console.WriteLine(menuItem.description);
        //    }
        //} 
        #endregion
    }
}
