using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.ToppingDecorators
{
    internal class CheeseTopping : ToppingDecorator
    {
        public CheeseTopping(Pizza pizza) : base(pizza, "cheese", 0.40M) { }
    }
}
