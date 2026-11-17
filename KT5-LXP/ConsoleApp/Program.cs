using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

            int a = 2;
            int b = 4;
            Utils.Swap(ref a, ref b); 

            Console.WriteLine("Числа после Swap: " + a + ", " + b);

            string x = "Братуха";
            string y = "42!";
            Utils.Swap(ref x, ref y); 

            Console.WriteLine("Строки после Swap: " + x + ", " + y);

            Pair<int, string> pair = new Pair<int, string>();
            pair.a = 42;
            pair.b = "Братуха";
            Console.WriteLine("Первое значение: " + pair.a + ", Второе значение: " + pair.b);
                
        }
    }
    
    
}
