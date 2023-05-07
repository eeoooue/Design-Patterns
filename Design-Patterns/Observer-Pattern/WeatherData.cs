using Observer_Pattern.WeatherDisplays;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    internal class WeatherData
    {

        private WeatherDisplay CurrentConditions = new CurrentConditionsDisplay();
        private WeatherDisplay Forecast = new ForecastDisplay();
        private WeatherDisplay Statistics = new StatisticsDisplay();

        public float GetTemperature()
        {
            return 20f;
        }

        public float GetHumidity()
        {
            return 11f;
        }

        public float GetPressure()
        {
            return 2f;
        }

        public void MeasurementsChanged()
        {
            //This method gets called
            //whenever the weather measurements
            //have been updated

            float temperature = GetTemperature();
            float humidity = GetHumidity();
            float pressure = GetPressure();

            CurrentConditions.Update(temperature, humidity, pressure);
            Forecast.Update(temperature, humidity, pressure);
            Statistics.Update(temperature, humidity, pressure);
        }
    }
}
