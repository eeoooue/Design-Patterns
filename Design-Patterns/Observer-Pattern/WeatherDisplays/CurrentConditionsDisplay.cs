using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern.WeatherDisplays
{
    internal class CurrentConditionsDisplay : Observer
    {
        private WeatherData _subject;

        private float _humidity;
        private float _pressure;
        private float _temperature;

        public CurrentConditionsDisplay(WeatherData subject)
        {
            _subject = subject;
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
