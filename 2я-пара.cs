using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


        }
    }

    abstract class Delivery
    {
        protected string name;
        protected decimal price;

        public string Name{
            get { return Name; }
            set
            {
                if (value != "" && value != null)
                {
                    Name = value;
                }
            }
        }

        public decimal Price
        {
            get { return price; }
        }
        public abstract decimal CalculatePrice(decimal basePrice);

        public override string ToString()
        {
            return $"Name: {name} Price: {price}";
        }
    }
    
    class StandardDelivery : Delivery()
    {
        public override decimal CalculatePrice(decimal basePrice)
        {
            return basePrice;
        }
    }
}
