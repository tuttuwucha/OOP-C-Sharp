using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class BookingService
    {
        public void Reserve(Seat seat, string movie)
        {

            seat.Reserve();
        }


    }
}
