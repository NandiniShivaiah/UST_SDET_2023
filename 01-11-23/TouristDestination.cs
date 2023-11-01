using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class TouristDestination
    {
        public TouristDestination(string? name, string? location,
           double rating, double price)
        {
            Name = name;
            Location = location;
            Rating = rating;
            Price = price;
        }

        public TouristDestination()
        {
        }

        public string? Name { get; set; }
        public string? Location { get; set; }
        public double Rating { get; set; }
        public double Price { get; set; }


        public void TopRated(List<TouristDestination> tours)
        {


            var res = tours.Where(t => t.Rating >= 5);
            foreach (var t in res)
            {
                Console.WriteLine("Name: " + t.Name + " Location: " + t.Location +
                                    " Rating: " + t.Rating + " Price: " + t.Price);
            }


        }

        public void PriceAscending(List<TouristDestination> tours)
        {
            var ans = tours.OrderBy(t => t.Rating);
            foreach (var t in ans)
            {
                Console.WriteLine("Name: " + t.Name + " Location: " + t.Location +
                    " Rating: " + t.Rating + " Price: " + t.Price);
            }
        }
        public void FilterDestination(string name, List<TouristDestination> tours)
        {
            var res1 = tours.Find(t => t.Name == name);
            if (res1 != null)
            {
                Console.WriteLine("Name: " + res1.Name + " Location: " + res1.Location +
                    " Rating: " + res1.Rating + " Price: " + res1.Price);
            }
            else
            {
                Console.WriteLine("Destination not available");
            }
        }
    }


}
