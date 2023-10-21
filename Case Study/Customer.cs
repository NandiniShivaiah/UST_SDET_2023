using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_study
{
    internal class Customer
    {

        private string? CustomerName;
        private string? CustomerNumber;
        private int CustomerId;

        public string? CustomerName1 { get => CustomerName; set => CustomerName = value; }
        public string? CustomerNumber1 { get => CustomerNumber; set => CustomerNumber = value; }
        public int CustomerId1 { get => CustomerId; set => CustomerId = value; }

        public void CustomerDetails(String? details)
        {
            CustomerNumber1 = details;
        }

        public void DisplayCustomerDetails()
        {
            Console.WriteLine("CustomerName:" + CustomerName + "CustomerNumber:" + CustomerNumber + "CustomerId:" + CustomerId);
        }
    }
}


        /*public string? CustomerName { get; set; }
        public int CustomerId { get; set; }
        public string? Customerdetails { get; set; }

        public void CustomerAccounts(int customerId)
        {
            CustomerId = customerId;
        }*/


    

