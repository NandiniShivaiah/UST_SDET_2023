using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Employee:Person,IDisplayable
    {
        public int EmployeeId { get; set; }
        public Employee(string? firstName, string? lastName, int age,int employeeId) : base(firstName, lastName, age)
        {
            FirstName = firstName;
            LastName = lastName;    
            Age = age;
            EmployeeId = employeeId;
        }

        
      

        

       

        public void DisplayInfo()
        {
            Console.WriteLine("Firstname:" + FirstName + "Lastname:" + LastName + "Age:" +
                Age + "employeeId:" + EmployeeId );
        }

      
    }
}
