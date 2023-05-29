using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.ToppingDecorators
{
    internal class MozzarellaTopping : ToppingDecorator
    {
        public MozzarellaTopping(Pizza pizza) : base(pizza, "mozzarella")
        {
        }
    }
}
