using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification_Library.Decorators
{
    internal class SlackDecorator : Decorator
    {
        public SlackDecorator(Notifier wrappee): base(wrappee) { }

        public override void Send()
        {
            Console.WriteLine($"Slack: {Wrappee.Message}");
            Wrappee.Send();
        }
    }
}
