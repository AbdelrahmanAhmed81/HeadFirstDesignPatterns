namespace DesignPatterns.ObserverPattern
{
    internal class WeatherDataState
    {
        public float Temperature, Humidity, Pressure;
        public WeatherDataState(float temp , float humidity , float pressure)
        {
            Temperature = temp;
            Humidity = humidity;
            Pressure = pressure;
        }
        public WeatherDataState() : this(0 , 0 , 0) { }
    }
}
