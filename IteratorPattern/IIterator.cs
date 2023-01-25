namespace DesignPatterns.IteratorPattern
{
    internal interface IIterator
    {
        bool hasNext();
        MenuItem next();
    }
}
