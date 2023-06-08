using Notification_Library.Decorators;

namespace Notification_Library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notifier notif = new Notifier("You have a message!");
            notif = new FacebookDecorator(notif);
            notif = new SlackDecorator(notif);
            notif = new SMSDecorator(notif);

            notif.Send();
        }
    }
}