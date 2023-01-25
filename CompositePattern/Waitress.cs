namespace DesignPatterns.CompositePattern
{
    internal class Waitress
    {
        MenuComponent menus;
        public Waitress(MenuComponent menus)
        {
            this.menus = menus;
        }
        public void printMenu()
        {
            Console.WriteLine("MENU");
            menus.print();
        }
    }
}
