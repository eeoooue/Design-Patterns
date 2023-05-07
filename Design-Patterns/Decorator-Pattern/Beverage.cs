using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    abstract class Beverage
    {

        protected string _description;

        public Beverage(string description)
        {
            _description = description;
        }

        public abstract decimal Cost();

        public virtual string GetDescription()
        {
            return _description;
        }

    }
}
