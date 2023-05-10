using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather_Station
{
    interface Display
    {
        void Display();
    }
    interface Observer
    {
        public void Update();
    }

    interface Subject
    {
        void RegisterObserver(Observer observer);

        void RemoveObserver(Observer observer);

        void NotifyObservers();
    }

    internal class WeatherData : Subject
    {
        private List<Observer> _observers = new List<Observer>();

        public float Humidity { get; private set; }
        public float Pressure { get; private set; }
        public float Temperature { get; private set; }

        public void SetMeasurements(float humidity, float pressure, float temperature)
        {
            Humidity = humidity;
            Pressure = pressure;
            Temperature = temperature;

            MeasurementsChanged();
        }

        private void MeasurementsChanged()
        {
            Console.WriteLine($"The weather station's measurements were changed!");
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
            foreach (Observer observer in _observers)
            {
                observer.Update();
            }
        }
    }

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

    internal class ForecastDisplay : Display, Observer
    {
        private WeatherData _subject;

        private float _humidity;
        private float _pressure;
        private float _temperature;

        public ForecastDisplay(WeatherData subject)
        {
            _subject = subject;
            subject.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine($"Forecast: [ {_temperature}°C | {_pressure} pressure | {_humidity} humidity ]");
        }

        public void Update()
        {
            _humidity = _subject.Humidity;
            _pressure = _subject.Pressure;
            _temperature = _subject.Temperature;
            Display();
        }
    }

    internal class StatisticsDisplay : Display, Observer
    {
        private WeatherData _subject;

        private float _humidity;
        private float _pressure;
        private float _temperature;

        public StatisticsDisplay(WeatherData subject)
        {
            _subject = subject;
            subject.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine($"Statistics: [ {_temperature}°C | {_pressure} pressure | {_humidity} humidity ]");
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
