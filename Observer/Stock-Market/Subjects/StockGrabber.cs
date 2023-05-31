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
            throw new NotImplementedException();
        }

        public void Register(Observer observer)
        {
            throw new NotImplementedException();
        }

        public void Unregister(Observer observer)
        {
            throw new NotImplementedException();
        }
    }
}
