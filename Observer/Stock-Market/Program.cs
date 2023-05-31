using Stock_Market.Observers;
using Stock_Market.Subjects;

namespace Stock_Market
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            StockGrabber grabber = new StockGrabber();
            grabber.setAAPLPrice(10.00);
            grabber.setGOOGPrice(10.00);
            grabber.setIBMPrice(10.00);

            StockObserver observer1 = new StockObserver(grabber);
            StockObserver observer2 = new StockObserver(grabber);

            grabber.setGOOGPrice(16.00);
        }
    }
}