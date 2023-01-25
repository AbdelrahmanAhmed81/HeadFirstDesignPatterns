using DesignPatterns.ObserverPattern.Interfaces;

namespace DesignPatterns.ObserverPattern.Displays
{
    internal class CurrentConditions : Interfaces.IObserver<WeatherDataState>, IDisplay
    {
        WeatherDataState _state;
        WeatherData _weatherData;
        public CurrentConditions(WeatherData weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }
        public void Display()
        {
            Console.WriteLine($"Tempreture = {_state.Temperature}\nHumidity = {_state.Humidity}\nPressure= {_state.Pressure}");
        }

        public void RemoveMe(ISubject<WeatherDataState> subject)
        {
            subject.RemoveObserver(this);
        }

        public void Update(WeatherDataState DataState)
        {
            _state = DataState;
            Display();
        }
    }
}
