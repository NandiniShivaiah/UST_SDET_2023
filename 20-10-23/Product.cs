using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Product


    {


        public Product(String? ProductName, double price, int quantity)
        {
            ProductName = ProductName;
            price = price;
            quantity = quantity;
        }

        public string? ProductName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public void SetPrice(double newPrice)
        {
            Price = newPrice;
        }
        public double ProductValue()
        {
            return Price * Quantity;
        }
        public void DisplayProduct()
        {
            Console.WriteLine("Product Name:" + ProductName + "Price:" + Price + "Quantity:" + Quantity");
        }
    }
}

        /*private string? productName;
        private double price,quantity;

        public string? ProductName { get => productName; set => productName = value; }
        public double Price { get => price; set => price = value; }
        public double Quantity { get => quantity; set => quantity = value; }

        public Product(string? productName, double price, double quantity)
        {
            this.ProductName = productName;
            this.Price = price;
            this.Quantity = quantity;
        }

        public void setPrice(double newPrice)
        {
            Price = newPrice;
        }
        public double ProductValue()
        {
            return Price*Quantity;
        }
        public void DisplayProductDetails()
        {
            Console.WriteLine("ProductName:{productName}");
            Console.WriteLine("Price:{price}");
            Console.WriteLine("Quantity:{quantity}");

        }
    }
}
