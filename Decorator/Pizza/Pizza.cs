using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    abstract class Pizza
    {
        public double Cost { get; set; }
        public string Description {get; set; }

        public Pizza(string description, double cost)
        {
            Cost = cost;
            Description = description;
        }
    }
}
