using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern.Beverages
{
    abstract internal class CondimentDecorator : Beverage
    {
        protected CondimentDecorator(string description) : base(description)
        {
        }

        public abstract override string GetDescription();
    }
}
