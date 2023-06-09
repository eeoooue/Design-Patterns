using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine_Subscriptions
{
    internal class Publisher
    {
        private List<Subscriber> _subscribers = new List<Subscriber>();

        public void Subscribe(Subscriber subscriber)
        {
            _subscribers.Add(subscriber);
        }

        public void Unsubscribe(Subscriber subscriber)
        {
            _subscribers.Remove(subscriber);
        }

        public void NotifySubscribers()
        {
            foreach (Subscriber subscriber in _subscribers)
            {
                subscriber.Update(this);
            }
        }
    }
}
