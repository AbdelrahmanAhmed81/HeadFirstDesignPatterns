namespace DesignPatterns.IteratorPattern
{
    internal class MenuItem
    {
        public string name { get; private set; }
        public string description { get; private set; }
        public bool vegetarian { get; private set; }
        public double price { get; private set; }
        public MenuItem(string name , string description , bool vegetarian , double price)
        {
            this.name = name;
            this.description = description;
            this.vegetarian = vegetarian;
            this.price = price;
        }
    }
}
