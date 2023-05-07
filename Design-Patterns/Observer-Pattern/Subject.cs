using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    interface Subject
    {
        void RegisterObserver();

        void RemoveObserver();

        void NotifyObservers();
    }
}
