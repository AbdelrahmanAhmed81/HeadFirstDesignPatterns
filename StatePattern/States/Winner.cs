namespace DesignPatterns.StatePattern.States
{
    internal class Winner:IState
    {
        public string Name => "Winner";
        GumballMachine machine;
        public Winner(GumballMachine machine)
        {
            this.machine = machine;
        }
        public void insertQuarter()
        {
            Console.WriteLine("Please wait , we’re already giving you a gumball");
        }
        public void ejectQuarter()
        {
            Console.WriteLine("Sorry , you already turned the crank");
        }
        public void turnCrank()
        {
            Console.WriteLine("Turning twice doesn’t get you another gumball!");
        }
        public void dispense()
        {
            Console.WriteLine("YOU’RE A WINNER! You get two gumballs for your quarter");
            machine.releaseBall();
            if (machine.getCount() == 0)
            {
                machine.setState(machine.getSoldOut());
            }
            else
            {
                machine.releaseBall();
                if (machine.getCount() > 0)
                {
                    machine.setState(machine.getNoQuarter());
                }
                else
                {
                    Console.WriteLine("Oops , out of gumballs!");
                    machine.setState(machine.getSoldOut());
                }
            }
        }
        public override string ToString() => $"{Name}";
    }
}
