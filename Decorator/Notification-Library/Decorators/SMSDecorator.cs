using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification_Library.Decorators
{
    internal class SMSDecorator : Decorator
    {
        public SMSDecorator(Notifier wrappee) : base(wrappee) { }

        public override void Send()
        {
            Console.WriteLine($"SMS: {Wrappee.Message}");
            Wrappee.Send();
        }
    }
}
