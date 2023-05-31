using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Market.Observers
{
    internal class StockObserver : Observer
    {
        private static int observerIdTracker = 1;

        public double IBMPrice { get; private set; }

        public double AAPLPrice { get; private set; }

        public double GOOGPrice { get; private set; }

        public int ID { get; private set; }

        public StockObserver(Subject source)
        {
            source.Register(this);
            ID = observerIdTracker++;
            Console.WriteLine($"New Observer: #{ID}");
        }

        public void Update(double ibmPrice, double aaplPrice, double googPrice)
        {
            IBMPrice = ibmPrice;
            AAPLPrice = aaplPrice;
            GOOGPrice = googPrice;

            Console.WriteLine($"Observer #{ID}:");

            Console.WriteLine($" - IBM: {IBMPrice}");
            Console.WriteLine($" - AAPL: {AAPLPrice}");
            Console.WriteLine($" - GOOG: {GOOGPrice}");
        }
    }
}
