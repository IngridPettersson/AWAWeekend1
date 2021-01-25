using System;
using System.Collections.Generic;
using System.Text;

namespace FruitSalad
{
    public class Fruit
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Fruit(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
