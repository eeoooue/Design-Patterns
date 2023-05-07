using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern.WeatherDisplays
{
    internal class CurrentConditionsDisplay : Display, Observer
    {
        private WeatherData _subject;

        private float _humidity;
        private float _pressure;
        private float _temperature;

        public CurrentConditionsDisplay(WeatherData subject)
        {
            _subject = subject;
            subject.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine($"Current Conditions: [ {_temperature}°C | {_pressure} pressure | {_humidity} humidity ]");
        }

        public void Update()
        {
            _humidity = _subject.Humidity;
            _pressure = _subject.Pressure;
            _temperature = _subject.Temperature;
            Display();
        }
    }
}
