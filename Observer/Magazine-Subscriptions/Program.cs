using Magazine_Subscriptions.Subscribers;

namespace Magazine_Subscriptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Publisher publisher = new Publisher();
            Reader henry = new Reader("Henry");
            Reader sophie = new Reader("Sophie");
            Reader james = new Reader("James");
            Reader alice = new Reader("Alice");

            Console.WriteLine($"At first, Henry, Sophie & Alice subscribe to the publisher.");
            publisher.Subscribe(henry);
            publisher.Subscribe(sophie);
            publisher.Subscribe(james);
            Console.WriteLine();

            Console.WriteLine($"When a magazine is published:");
            publisher.NotifySubscribers();
            Console.WriteLine();

            Console.WriteLine($"Alice subscribes.");
            publisher.Subscribe(alice);
            Console.WriteLine($"James unsubscribes.");
            publisher.Unsubscribe(james);
            Console.WriteLine();

            Console.WriteLine($"When a magazine is published:");
            publisher.NotifySubscribers();
            Console.WriteLine();
        }
    }
}