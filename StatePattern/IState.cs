namespace DesignPatterns.StatePattern
{
    internal interface IState
    {
        string Name { get; }
        void insertQuarter();
        void turnCrank();
        void ejectQuarter();
        void dispense();
    }
}
