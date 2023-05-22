using Restaurant.Burgers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    internal class Restaurant
    {

        public Burger OrderBurger(string request)
        {
            Burger burger;

            if (request == "veggie")
            {
                burger = new VeggieBurger();
            }
            else
            {
                burger = new BeefBurger();
            }

            burger.Prepare();
            return burger;
        }
    }
}
