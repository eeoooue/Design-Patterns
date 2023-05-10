namespace Weather_Station
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Display> displays = new List<Display>();

            WeatherData station = new WeatherData();

            displays.Add(new CurrentConditionsDisplay(station));
            displays.Add(new ForecastDisplay(station));
            displays.Add(new StatisticsDisplay(station));

            station.SetMeasurements(10, 10, 10);
            station.SetMeasurements(20, 10, 29);
            station.SetMeasurements(10, 30, 10);
        }
    }
}