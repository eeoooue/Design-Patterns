using Restaurant.Burgers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Restaurants
{
    internal class BeefBurgerRestaurant : Restaurant
    {
        public override Burger CreateBurger()
        {
            return new BeefBurger();
        }
    }
}
