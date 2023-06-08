using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification_Library
{
    internal class Notifier
    {
        public string Message { get; private set; }

        public Notifier(string message)
        {
            Message = message;
        }
    }
}
