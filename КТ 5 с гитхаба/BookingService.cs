using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class BookingService
    {
        public static void Reserve(CinemaHall hall, int seatNumber)
        {
            if(seatNumber < 1 || seatNumber > hall.Seats.Count)
            {
                Console.WriteLine("You have entered an invalid number! Valid numbers are 1-" + hall.Seats.Count);
                return;
            }

            hall.Seats[seatNumber - 1].Reserve();
        }
    }
}
