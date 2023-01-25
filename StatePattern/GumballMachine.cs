using DesignPatterns.StatePattern.States;

namespace DesignPatterns.StatePattern
{
    internal class GumballMachine
    {
        public IState HasQuarter;
        public IState NoQuarter;
        public IState SoldOut;
        public IState Sold;
        public IState Winner;


        IState CurrentState;
        int GumsCount;
        public GumballMachine(int gumsCount = 0)
        {
            HasQuarter = new HasQuarter(this);
            NoQuarter = new NoQuarter(this);
            SoldOut = new SoldOut(this);
            Sold = new Sold(this);
            Winner = new Winner(this);

            CurrentState = SoldOut;
            GumsCount = gumsCount;
            if (gumsCount > 0)
            {
                CurrentState = NoQuarter;
            }
        }
        public void insertQuarter()
        {
            CurrentState.insertQuarter();
        }
        public void ejectQuarter()
        {
            CurrentState.ejectQuarter();
        }
        public void turnCrank()
        {
            CurrentState.turnCrank();
            if (CurrentState is Sold || CurrentState is Winner)
                CurrentState.dispense();
        }
        public void releaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");
            if (GumsCount != 0)
            {
                GumsCount--;
            }
        }
        public void setState(IState state)
        {
            CurrentState = state;
        }
        public IState getCurrentState() => CurrentState;
        public int getCount() => GumsCount;
        public IState getHasQuarter() => HasQuarter;
        public IState getNoQuarter() => NoQuarter;
        public IState getSold() => Sold;
        public IState getSoldOut() => SoldOut;
        public IState getWinner() => Winner;
        public override string ToString()
        {
            return $"Current State = {CurrentState}, Gum balls left = {GumsCount}";
        }
    }
}
