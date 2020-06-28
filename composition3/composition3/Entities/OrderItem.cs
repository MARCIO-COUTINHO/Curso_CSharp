﻿using System;
using System.Collections.Generic;
using System.Text;

namespace composition3.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }

        public Product Product = new Product();

        public OrderItem ()
        {

        }
        public OrderItem(int quantity, double price)
        {
            Quantity = quantity;
            Price = price;
        }
        public double SubTotal ()
        {
            return Quantity * Price;
        }
    }
}
