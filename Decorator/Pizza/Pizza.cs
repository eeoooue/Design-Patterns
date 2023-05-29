using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    abstract class Pizza
    {
        protected double _cost;
        protected string _description;

        public Pizza() { }

        public virtual double GetCost()
        {
            return 0;
        }

        public virtual string GetDescription()
        {
            return "Pizza";
        }
    }
}
