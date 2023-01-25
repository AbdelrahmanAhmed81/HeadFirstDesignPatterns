using DesignPatterns.ObserverPattern.Interfaces;

namespace DesignPatterns.ObserverPattern
{
    internal class WeatherData : ISubject<WeatherDataState>
    {
        List<Interfaces.IObserver<WeatherDataState>> _observers;
        WeatherDataState _weatherDataState;
        public WeatherData()
        {
            _weatherDataState = new();
            _observers = new();
        }

        public void ChangeWeatherData(WeatherDataState weatherData)
        {
            _weatherDataState = weatherData;
            MeasurementsChanged();
        }

        void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void RegisterObserver(Interfaces.IObserver<WeatherDataState> observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(Interfaces.IObserver<WeatherDataState> observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_weatherDataState);
            }
        }
    }
}
