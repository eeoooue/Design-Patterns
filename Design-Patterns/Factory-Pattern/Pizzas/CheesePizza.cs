using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern.Pizzas
{
    internal class CheesePizza : Pizza
    {
        public CheesePizza(string style) : base(style) { }
    }
}
