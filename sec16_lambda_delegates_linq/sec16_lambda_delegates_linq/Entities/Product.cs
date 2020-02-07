using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace sec16_comparison.Entities
{
    class Product
    {
        public string Name { get; private set; }
        public double Price { get; private set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"Name: {Name}, {Price.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
