using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern
{
    internal class Pizza
    {

        public string _style;

        public Pizza(string style)
        {
            _style = style;
        }

        public void Prepare()
        {
            
        }

        public void Bake()
        {
            
        }

        public void Cut()
        {
            
        }

        public void Box()
        {
            
        }
    }

    internal class CheesePizza : Pizza
    {
        public CheesePizza(string style) : base(style) { }
    }

    internal class ClamPizza : Pizza
    {
        public ClamPizza(string style) : base(style) { }
    }

    internal class GreekPizza : Pizza
    {
        public GreekPizza(string style) : base(style) { }
    }

    internal class PepperoniPizza : Pizza
    {
        public PepperoniPizza(string style) : base(style) { }
    }

    internal class VeggiePizza : Pizza
    {
        public VeggiePizza(string style) : base(style) { }
    }
}
