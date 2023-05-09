﻿using Observer_Pattern.WeatherDisplays;
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
            foreach(Observer observer in _observers)
            {
                observer.Update();
            }
        }
    }
}