using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Customer
    {
        public Customer()
        {
        }

        public Customer(int customerId, string? name, int phoneNumber, double balance)
         {
             CustomerId = customerId;
             Name = name;
             PhoneNumber = phoneNumber;
             Balance = balance;
         }

         public int CustomerId { get; set; }

         public string? Name { get; set; }
         public int PhoneNumber { get; set; }
         public double Balance { get; set; }

        
       
        public  void SearchByPhoneNumber()
        {
            if(PhoneNumber.Equals(PhoneNumber))
            {
                Console.WriteLine("CustomerName:" + Name + "Balance:" +Balance);
            }
            else
            {
                Console.WriteLine("Customer Not found");
            }
        }

        public void DisplayDetails()
        {

          
            
                Console.WriteLine("CustomerName:" + Name + "CustomerId:" + CustomerId + "Phonenumber:" + PhoneNumber + "Balance:" + Balance);
            
        }









        }
        

        
        
        
       
        
       


    }
