using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm_Restaurant.DishDecorators
{
    /// <summary>
    /// A ConcreteDecorator. This class will impart "responsibilities" onto the dishes 
    /// (e.g. whether or not those dishes have enough ingredients left to order them)
    /// </summary>
    class Available : DishDecorator
    {
        public int NumAvailable { get; set; } //How many can we make?
        protected List<string> customers = new List<string>();
        public Available(RestaurantDish dish, int numAvailable) : base(dish)
        {
            NumAvailable = numAvailable;
        }

        public void OrderItem(string name)
        {
            if (NumAvailable > 0)
            {
                customers.Add(name);
                NumAvailable--;
            }
            else
            {
                Console.WriteLine("\nNot enough ingredients for " + name + "'s order!");
            }
        }

        public override void Display()
        {
            base.Display();

            foreach (string customer in customers)
            {
                Console.WriteLine("Ordered by " + customer);
            }
        }
    }
}
