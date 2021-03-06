﻿
using System.Globalization;
namespace sec09_exe_prop01.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }

        public Product Product { get; set; }
        public double Price { get; set; }

        public OrderItem() { }

        public OrderItem(int quantity, Product product)
        {
            Quantity = quantity;
            Product = product;
            Price = product.Price;
        }

        public double SubTotal()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            return Product.Name + ", $" + Price.ToString("F2", CultureInfo.InvariantCulture) + ", Quantity: " + Quantity + ", Subtotal: $" + SubTotal().ToString("F2",CultureInfo.InvariantCulture); 
        }
    }
}
