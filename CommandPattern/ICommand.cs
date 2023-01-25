namespace DesignPatterns.CommandPattern
{
    internal interface ICommand
    {
        void Execute();
        void Undo();
    }
}
