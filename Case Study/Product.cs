using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_study
{
    internal class Product
    {

        public static List<Product> Products = new List<Product>();
        public int ProductID { get; set; }
        public string? Name { get; set; }
        public double Price { get; set; }
        public int StockQuantity { get; set; }
    }
}


      