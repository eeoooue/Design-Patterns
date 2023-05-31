using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Market
{
    internal interface Subject
    {
        public void Register(Observer observer);

        public void Unregister(Observer observer);

        public void NotifyObservers();
    }
}
