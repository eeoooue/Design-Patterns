using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern.WeatherDisplays
{
    internal class StatisticsDisplay : Observer
    {
        private WeatherData _subject;

        private float _humidity;
        private float _pressure;
        private float _temperature;

        public StatisticsDisplay(WeatherData subject)
        {
            _subject = subject;
        }

        public void Update()
        {
            _humidity = _subject.GetHumidity();
            _pressure = _subject.GetPressure();
            _temperature = _subject.GetTemperature();
        }
    }
}
