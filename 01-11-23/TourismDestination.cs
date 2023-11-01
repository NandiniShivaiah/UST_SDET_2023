using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class TourismDestination
    {
        public TourismDestination(string? name, string? country, int rate)
        {
            Name = name;
            Country = country;
            Rate = rate;
        }

        public string? Name { get; set; }
        public string? Country { get; set; }
        public int Rate { get; set; }



        public static void SortOnRating(List<TourismDestination> list)
        {
            if (list != null)
            {
                var rate = list.OrderByDescending(
                a => a.Rate);
                foreach (var l in rate)
                {
                    Console.WriteLine("Destination name: " + l.Name +
                        " Country: " + l.Country + " Rating: " + l.Rate);
                }
            }
            else
            {
                Console.WriteLine("No destination added");
            }

        }
    }
}