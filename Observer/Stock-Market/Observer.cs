using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Market
{
    internal interface Observer
    {
        public void Update(double ibmPrice, double aaplPrice, double googPrice);
    }
}
