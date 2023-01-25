namespace DesignPatterns.SingletonPattern
{
    internal class ChocolateBoiler
    {
        bool empty;
        bool boiled;
        private static ChocolateBoiler Instance;
        private ChocolateBoiler()
        {
            empty = true;
            boiled = false;
        }
        public static ChocolateBoiler getInstance()
        {
            if (Instance == null)
                Instance = new ChocolateBoiler();
            return Instance;
        }
        public void fill()
        {
            if (isEmpty())
            {
                empty = false;
                boiled = false;
                // fill the boiler with a milk/chocolate mixture
            }
        }
        public void drain()
        {
            if (!isEmpty() && isBoiled())
            {
                // drain the boiled milk and chocolate
                empty = true;
            }
        }
        public void boil()
        {
            if (!isEmpty() && !isBoiled())
            {
                // bring the contents to a boil
                boiled = true;
            }
        }
        public bool isEmpty()
        {
            return empty;
        }
        public bool isBoiled()
        {
            return boiled;
        }
    }
}
