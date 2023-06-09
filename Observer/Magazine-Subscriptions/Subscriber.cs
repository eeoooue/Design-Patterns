using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazine_Subscriptions
{
    internal interface Subscriber
    {
        void Update(Publisher publisher);
    }
}
