﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern.Pizzas
{
    internal class GreekPizza : Pizza
    {
        public GreekPizza(string style) : base(style) { }
    }
}