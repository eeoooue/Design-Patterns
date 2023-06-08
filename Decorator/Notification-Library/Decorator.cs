using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification_Library
{
    abstract class Decorator : Notifier
    {
        public Notifier Wrappee { get; set; }

        public Decorator(Notifier wrappee) : base(wrappee.Message)
        {
            Wrappee = wrappee;
        }
        public override abstract void Send();
    }
}
