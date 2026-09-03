using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Animal();
            cat.type = "Cat";
            cat.age = 5;
            cat.name = "kot";
            cat.sound = "mew";
            Console.WriteLine(cat.getInfo());
            Console.WriteLine(cat.sayHello()); 
            Console.In.ReadLine();


        }
    }


    public class Animal
    {
        public string type;
        public int age;
        public string name;
        public string sound;

        public string getInfo()
        {
            return $"Вид: {type}\nВозраст {age}\nКличка {name}";
        }


        public string sayHello()
        {
            return sound;
        }
    }
}
