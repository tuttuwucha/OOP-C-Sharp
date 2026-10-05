using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Seat
    {
        public int Number { get; set; }
        public bool isOccupied { get; set; }
        public void Reserve()
        {
            if (!isOccupied)
            {
                isOccupied = true;
                Console.WriteLine("Место зарезервировано");
            }
            else
            {
                Console.WriteLine("Место уже занято");
            }
        }
        public Seat(int number)
        {
            Number = number;
            isOccupied = false;
        }
    }
}
