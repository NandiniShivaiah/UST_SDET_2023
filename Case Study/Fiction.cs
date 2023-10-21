using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_study
{
    internal class Fiction : Book
    {

        public String? Categories { get; set; }
        public void DisplayFictionDetails()
        {
            Console.WriteLine("Title:{0}\n,Author:{1}\n,ISBN:{2}\n,Price:{3}\n,,Availability:{4}", Title,
                Author, ISBN, Price, Availability);
        }
        public void SearchFictionBook()
        {
            Console.WriteLine("Eneter the book");
            string? BookName = Console.ReadLine();
            if (BookName.Equals(Title))
            {
                Console.WriteLine("Book is Avaialable");
            }
            else
            {
                Console.WriteLine("Book is not Avaialable");
            }
        }





        /* private string? Title { get; set; }
         private string? Author { get; set;}
         private string? ISBN { get; set; }
         private int Price { get; set; }

         private string? Availability { get; set; }




         public void DisplayFiction()
         {
             Console.WriteLine("Title:{0}\n,Author:{1}\n,ISBN:{2}\n,Price:{3}\n,,Availability:{4}",Title,
                 Author,ISBN,Price,Availability);
         }*/

    }
}
