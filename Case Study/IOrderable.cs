using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_study
{
    internal interface IOrderable
    {
        public void PlaceOrders(int quantity, List<Product> p);
        public void ProcessPayment(int orderId, Order order);
        public void DeliverOrders(string? phoneNumber, Order order);
    }

}
