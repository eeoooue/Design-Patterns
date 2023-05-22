using Restaurant.Burgers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    internal class SimpleBurgerFactory
    {
        public SimpleBurgerFactory() { }

        public Burger CreateBurger(string request)
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

            return burger;
        }
    }
}
