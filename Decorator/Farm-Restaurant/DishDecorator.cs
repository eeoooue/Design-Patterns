using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm_Restaurant
{
    /// <summary>
    /// The abstract Decorator class.  
    /// </summary>
    abstract class DishDecorator : RestaurantDish
    {
        protected RestaurantDish _dish;

        public DishDecorator(RestaurantDish dish)
        {
            _dish = dish;
        }

        public override void Display()
        {
            _dish.Display();
        }
    }
}
