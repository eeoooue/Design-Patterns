using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Market
{
    /// <summary>
    /// The Observer interface
    /// </summary>
    interface IRestaurant
    {
        void Update(Vegetable veggies);
    }
}
