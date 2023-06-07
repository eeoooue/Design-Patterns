using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistics_App
{
    interface Logistics
    {
        public abstract void PlanDelivery();

        public abstract Transport CreateTransport();
    }
}
