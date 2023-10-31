using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class RoomReservation<T> : HotelRoom
    {

        public void Booking<T>(int roomNum)
        {
            if (RoomNumber == roomNum)
            {
                IsBooked = true;
                Console.WriteLine("Booking confirmed");
            }
            else
            {
                Console.WriteLine("Booking not available" +
                    " with this Room number");
            }



        }

        public void Cancelation<T>(int roomNum)
        {
            if (RoomNumber == roomNum && IsBooked == true)
            {

                Console.WriteLine("Booking Canceled");
            }
            else
            {
                Console.WriteLine("Cannot cancel because " +
                    " no booking available with" +
                    " this Room number");
            }

        }
    }
}
       /*
       public void BookRoom( RoomNumber room )
        {
            if(room != null && !room.ISBooked)
            {
                room.ISBooked = true;
                Console.WriteLine("Room has been booked");
            }
            else
            {
                Console.WriteLine("Room not available/ already booked");
            }
            
        }

        public void CancelReservation(RoomNumber room)
        {
            if (room != null && !room.ISBooked)
            {
                room.ISBooked = false;
                Console.WriteLine("Cancel reservation");
            }
            else
            {
                Console.WriteLine("Room  already booked");
            }
           
        }

           
            

        }
        
    }
}
*/