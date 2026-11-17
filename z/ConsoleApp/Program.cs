using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Box<int> box1 = new Box<int>();
            box1.Put(42);
            Box<string> box2 = new Box<string>();
            box2.Put("Братуха");

            Console.WriteLine(box1.ToString());
            Console.WriteLine(box2.ToString());
            
            
                
        }
    }
    
    
}
