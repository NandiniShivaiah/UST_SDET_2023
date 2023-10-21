using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_study
{
    internal class Order:Customer
    {

        public int OrderId { get; set; }

        public Book? books { get; set; }

        public void ProcessOrder(Book book)
        {
            Console.WriteLine("Order Details:" + CustomerId1, CustomerName1);
            Console.WriteLine("Book oreder:" + book.Title, book.Author);
        }

        public double CalculateCost(Book book)
        {
           double  TotalCost = book.Price;
            return TotalCost;
        }

       /* public List<Book> Books { get; set; }
        public DateTime OrderDate { get; set; }
        public double TotalCost { get; set; }

        public void  ProOrder()
        {
            Books = new List<Book>();

            OrderDate = DateTime.Now;
            TotalCost = 0;
        }
        public void AddBookToOrder(Book book)
        {
            Books.Add(book);
            TotalCost += book.Price;
        }*/


        



    }
}
