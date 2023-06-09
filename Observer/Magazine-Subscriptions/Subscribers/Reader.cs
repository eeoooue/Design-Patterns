using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine_Subscriptions.Subscribers
{
    internal class Reader : Subscriber
    {
        public string Name { get; private set; }

        public Reader(string name)
        {
            Name = name;
        }

        public void Update(Publisher publisher)
        {
            Console.WriteLine($"{Name} was notified by the publisher");
        }
    }
}
