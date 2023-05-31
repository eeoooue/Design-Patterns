using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Market.Subjects
{
    internal class StockGrabber : Subject
    {
        private List<Observer> _observers;

        public double IBMPrice { get; private set; }

        public double AAPLPrice { get; private set; }

        public double GOOGPrice { get; private set; }

        public StockGrabber()
        {
            _observers = new List<Observer>();
            IBMPrice = 0;
            AAPLPrice = 0;
            GOOGPrice = 0;
        }

        public void NotifyObservers()
        {
            foreach(Observer observer in _observers)
            {
                observer.Update();
            }
        }

        public void Register(Observer observer)
        {
            _observers.Add(observer);
        }

        public void Unregister(Observer observer)
        {
            _observers.Remove(observer);
        }

        public void setIBMPrice(double price)
        {
            IBMPrice = price;
            NotifyObservers();
        }

        public void setAAPLPrice(double price)
        {
            AAPLPrice = price;
            NotifyObservers();
        }

        public void setGOOGPrice(double price)
        {
            GOOGPrice = price;
            NotifyObservers();
        }
    }
}
