using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class CinemaHall
    {
        public List<Seat> Seats = new List<Seat>();
        public Movie movie;
        

        public override string ToString()
        {
            string text = "Свободные места для " + movie.Title + ":";
            for(int i = 1; i <= Seats.Count; i++)
            {
                string seatStatus = Seats[i - 1].isOccupied ? "занято" : "свободно";
                text += "\nКресло " + i + ": " + seatStatus;
            }
            return text;
        }

        public CinemaHall(Movie inMovie, int numberOfSeats)
        {
            if(numberOfSeats < 1)
            {
                throw new ArgumentException("Number of seats can't be less than 1");
            }
            for(int i = 1; i <= numberOfSeats; i++)
            {
                Seat newSeat = new Seat(i);
                Seats.Add(newSeat);
            }

            movie = inMovie;
        }
    }
}
