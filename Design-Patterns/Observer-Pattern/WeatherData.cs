using Observer_Pattern.WeatherDisplays;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    internal class WeatherData : Subject
    {

        private List<Observer> _observers = new List<Observer>();

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

            NotifyObservers();
        }

        public void RegisterObserver(Observer observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(Observer observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach(Observer observer in _observers)
            {
                observer.Update();
            }
        }
    }
}
