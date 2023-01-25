namespace DesignPatterns.StatePattern.States
{
    internal class HasQuarter : IState
    {
        public string Name => "Has Quarter";
        Random random = new Random();
        GumballMachine machine;
        public HasQuarter(GumballMachine machine)
        {
            this.machine = machine;
        }
        public void insertQuarter()
        {
            Console.WriteLine("You can’t insert another quarter");
        }
        public void ejectQuarter()
        {
            Console.WriteLine("Quarter returned");
            machine.setState(machine.getNoQuarter());
        }
        public void turnCrank()
        {
            Console.WriteLine("You turned...");
            int randomGenerated = random.Next(0 , 10);
            if (randomGenerated == 7 && machine.getCount() > 1)
                machine.setState(machine.getWinner());
            else
                machine.setState(machine.getSold());
        }
        public void dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }
        public override string ToString() => $"{Name}";
    }
}
