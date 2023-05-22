using Restaurant.Burgers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    abstract class Restaurant
    {
        public Burger OrderBurger()
        {
            Burger burger = CreateBurger();
            burger.Prepare();
            return burger;
        }

        public abstract Burger CreateBurger();
    }
}
