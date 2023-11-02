using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class TourPackage
    {
        public TourPackage(int packageId, string? destination,
           DateOnly? startDate, double price)
        {
            PackageId = packageId;
            Destination = destination;
            StartDate = startDate;
            Price = price;
        }

        public TourPackage() { }

        public int PackageId { get; set; }
        public string? Destination { get; set; }
        public DateOnly? StartDate { get; set; }
        public double Price { get; set; }

        public void TourBooking(TourPackage tp)
        {
            lock (tp)
            {

                Console.WriteLine("Booking");
                Thread.Sleep(1000);
                Console.WriteLine("Package Id: " + tp.PackageId + " Destination: " +
                    tp.Destination + " Start date: " + tp.StartDate +
                    " Price: " + tp.Price);


            }

        }
    }
}
