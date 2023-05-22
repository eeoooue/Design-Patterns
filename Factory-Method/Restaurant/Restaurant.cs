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
        private SimpleBurgerFactory _factory = new SimpleBurgerFactory();

        public Burger OrderBurger(string request)
        {
            Burger burger = _factory.CreateBurger(request);
            burger.Prepare();
            return burger;
        }
    }
}
