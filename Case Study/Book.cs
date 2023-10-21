using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case_study
{
    internal class Book
    {
        

        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? ISBN { get; set; }
        public int Price { get; set; }
        public string? Availability { get; set; }

        public void SearchBook()
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

        public void DisplayBook()
        {
            Console.WriteLine("Title:" + Title + "Author:" + Author + "ISBN:" + ISBN + "Price:" + Price + "Availability:" + Availability);
        }


                                                                                                                                                                                                
       

    }
}
