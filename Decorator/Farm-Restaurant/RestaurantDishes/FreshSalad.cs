﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm_Restaurant.RestaurantDishes
{
    /// <summary>
    /// A ConcreteComponent class
    /// </summary>
    class FreshSalad : RestaurantDish
    {
        private string _greens;
        private string _cheese;
        private string _dressing;

        public FreshSalad(string greens, string cheese, string dressing)
        {
            _greens = greens;
            _cheese = cheese;
            _dressing = dressing;
        }

        public override void Display()
        {
            Console.WriteLine("\nFresh Salad:");
            Console.WriteLine(" Greens: {0}", _greens);
            Console.WriteLine(" Cheese: {0}", _cheese);
            Console.WriteLine(" Dressing: {0}", _dressing);
        }
    }
}
