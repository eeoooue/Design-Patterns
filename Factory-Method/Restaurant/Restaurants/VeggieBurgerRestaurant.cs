using Restaurant.Burgers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Restaurants
{
    internal class VeggieBurgerRestaurant : Restaurant
    {
        public override Burger CreateBurger()
        {
            return new VeggieBurger();
        }
    }
}
