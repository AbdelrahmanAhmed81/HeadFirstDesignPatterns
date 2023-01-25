namespace DesignPatterns.StatePattern.States
{
    internal class NoQuarter : IState
    {
        public string Name => "No Quarter";
        GumballMachine machine;
        public NoQuarter(GumballMachine machine)
        {
            this.machine = machine;
        }
        public void insertQuarter()
        {
            Console.WriteLine("You inserted a quarter");
            machine.setState(machine.getHasQuarter());
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
