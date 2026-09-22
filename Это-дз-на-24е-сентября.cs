using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1                                                                                                   
{
    class Program
    {
        static void Main(string[] args)
        {
            Delivery standard = new StandardDelivery("1");
            Delivery express = new ExpressDelivery("2");
            Delivery international = new InternationalDelivery("3");
            
            standard.CalculatePrice(20m);
            express.CalculatePrice(20m);
            international.CalculatePrice(20m);
            
            Console.WriteLine(standard.ToString());
            Console.WriteLine(express.ToString());
            Console.WriteLine(international.ToString());

            
            Console.ReadLine();

        }
    }

    abstract class Delivery
    {
        protected string name = "";
        protected decimal price = 0m;

        public string Name{
            get { return name; }
            set
            {
                if (value == "" || value == null)
                {
                    Console.WriteLine("Name of the delivery can not be empty");
                    return;
                }
                if(value.Length > 20)
                {
                    Console.WriteLine("Name of the delivery can not be longer than 20 characters");
                    return;
                }
                name = value;
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
    
    class StandardDelivery : Delivery
    {
        public StandardDelivery(string name){
            Name = name;
        }
        
        public override decimal CalculatePrice(decimal basePrice)
        {
            price = basePrice;
            return price;
        }
    }
    class ExpressDelivery : Delivery
    {
        public ExpressDelivery(string name){
            Name = name;
        }
        
        public override decimal CalculatePrice(decimal basePrice)
        {
            price = basePrice * 2.5m;
            return price;
        }
    }
    class InternationalDelivery : Delivery
    {
        public InternationalDelivery(string name){
            Name = name;
        }
        
        public override decimal CalculatePrice(decimal basePrice)
        {
            price = basePrice * 4m;
            return price;
        }
    }
}
