﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    internal class Product
    {
        public string Name { get; private set; }
        public int Price { get; private set; }



        public Product(string name, int price)
        {
            Name = name;
            Price = price;

        }
    }
}
