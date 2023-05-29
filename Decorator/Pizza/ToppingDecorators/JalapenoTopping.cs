using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.ToppingDecorators
{
    internal class JalapenoTopping : ToppingDecorator
    {
        public JalapenoTopping(Pizza pizza) : base(pizza, "jalapeno", 0.60M) { }
    }
}
