using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification_Library
{
    abstract class Decorator
    {
        private Notifier Wrappee { get; set; }

        public Decorator(Notifier wrappee)
        {
            Wrappee = wrappee;
        }
        public abstract void Send();
    }
}
