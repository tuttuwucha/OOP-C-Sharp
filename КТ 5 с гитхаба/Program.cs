using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie movie = new Movie("Опенгеймер", 100);

            CinemaHall cinemaHall = new CinemaHall(movie, 25);
            
            Console.WriteLine(cinemaHall.ToString());

            BookingService.Reserve(cinemaHall, 15);

            Console.WriteLine(cinemaHall.ToString());

            Console.ReadLine();
        }
    }
}
