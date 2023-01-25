namespace DesignPatterns.ObserverPattern.Interfaces
{
    internal interface ISubject<T>
    {
        void RegisterObserver(IObserver<T> observer);
        void RemoveObserver(IObserver<T> observer);
        void NotifyObservers();
    }
}
