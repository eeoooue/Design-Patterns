using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen
{
    /// <summary>
    /// Each section of the kitchen must implement this interface.
    /// </summary>
    interface IKitchenSection
    {
        FoodItem PrepDish(int DishID);
    }
}
