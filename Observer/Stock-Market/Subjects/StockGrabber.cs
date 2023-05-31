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

        public StockGrabber()
        {
            _observers = new List<Observer>();
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
    }
}
