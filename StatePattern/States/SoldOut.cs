namespace DesignPatterns.StatePattern.States
{
    internal class SoldOut : IState
    {
        public string Name => "Sold Out";
        GumballMachine machine;
        public SoldOut(GumballMachine machine)
        {
            this.machine = machine;
        }
        public void insertQuarter()
        {
            Console.WriteLine("Sorry! no gum balls left");
        }
        public void ejectQuarter()
        {
            Console.WriteLine("You haven’t inserted a quarter");
        }
        public void turnCrank()
        {
            Console.WriteLine("You turned , but there’s no quarter");
        }
        public void dispense()
        {
            Console.WriteLine("You need to pay first");
        }
        public override string ToString() => $"{Name}";

    }
}
