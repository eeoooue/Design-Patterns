using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification_Library.Decorators
{
    internal class FacebookDecorator : Decorator
    {
        public FacebookDecorator(Notifier wrappee) : base(wrappee) { }

        public override void Send()
        {
            Console.WriteLine($"Facebook: {Wrappee.Message}");
            Wrappee.Send();
        }
    }
}
