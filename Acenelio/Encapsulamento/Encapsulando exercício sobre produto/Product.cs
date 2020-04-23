using System;
using System.Collections.Generic;
using System.Text;

namespace Acenelio
{
    class Product
    {
        public String name;
        public double price;
        public double quantity;

        public Product(string name, double price, double quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        public double valueStock()
        {
            return this.price * this.quantity;
        }

        public void addProduct(int quantity)
        {
            this.quantity += quantity;
        }

        public void removeProduct(int quantity)
        {
            this.quantity -= quantity;
        }
    }
}
