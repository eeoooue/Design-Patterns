using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    public class Pizza
    {
        protected decimal _cost;
        protected string _description;

        public Pizza(string description, decimal cost)
        {
            _cost = cost;
            _description = description;
        }

        public virtual decimal GetCost()
        {
            return _cost;
        }

        public virtual string GetDescription()
        {
            return _description;
        }
    }
}
