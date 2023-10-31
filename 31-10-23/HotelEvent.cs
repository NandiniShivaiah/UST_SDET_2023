using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class HotelEvent
    {
         
        public string? EventName { get; set; }
        public DateTime Time { get; set; }
        public string? Location { get; set; }
        public int Capacity { get; set; }

        public void RegisterToEvent()
        {
            Console.WriteLine("enter the event name to register");
            EventName = Console.ReadLine();
            Console.WriteLine("time of the event");
            Time = DateTime.Now;
            Console.WriteLine("Location of event");
            Location = Console.ReadLine();
            Console.WriteLine("Capacity of seating");
            Capacity = Convert.ToInt32(Console.ReadLine());
        }

        public void EventNotification(string eName)
        {
            if (EventName == eName)
            {
                Console.WriteLine("upcoming event: " + EventName);
            }
            else
            {
                Console.WriteLine("No events");
            }
        }
    }
}
