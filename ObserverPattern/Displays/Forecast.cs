using DesignPatterns.ObserverPattern.Interfaces;

namespace DesignPatterns.ObserverPattern.Displays
{
    internal class Forecast : Interfaces.IObserver<WeatherDataState>, IDisplay
    {
        WeatherDataState _state;
        WeatherData _weatherData;
        public Forecast(WeatherData weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }
        public void Display()
        {
            if (_state.Temperature < 20)
            {
                Console.WriteLine("It May Be Rainy Today, bring your umbrella");
            }
            else
            {
                Console.WriteLine("It May Be Sunny Today, wearing white clothes will be good");
            }
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
