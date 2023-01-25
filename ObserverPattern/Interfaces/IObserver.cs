namespace DesignPatterns.ObserverPattern.Interfaces
{
    internal interface IObserver<T>
    {
        void Update(T DataState);
        void RemoveMe(ISubject<T> subject);
    }
}
