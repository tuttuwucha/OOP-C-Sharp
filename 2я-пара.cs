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
            Animal cat = new Animal("catr", 10, "namer");
            
            Console.WriteLine(cat.getInfo());
            
            Console.In.ReadLine();


        }
    }


    public class Animal
    {
        private string type;
        private int age;
        private string name;
        private string sound;

        public Animal(string Type, int Age, string Name)
        {
            type = Type;
            age = Age;
            name = Name;
        }
        public Animal()
        {

        }

        public string Type
        {
            get { return type; }
            set 
            {
                if(value == null || value == "")
                {
                    Console.WriteLine("You have to enter a type");
                }
                else
                {
                    type = value;
                }
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value == null || value >= 100)
                {
                    Console.WriteLine("You have entered invalid value");

                }
                else
                {
                    age = value;
                }
            }
        }
        
        public string Name
        {
            get { return name; }
            set
            {
                if (value == null || value == "")
                {
                    Console.WriteLine("You have to enter a name");
                }
                else
                {
                    name = value;
                }
            }
        }

        public string Sound
        {
            get { return sound; }
            set
            {
                if (value == null || value == "")
                {
                    Console.WriteLine("You have to enter a sound");

                }
                else
                {
                    sound = value;
                }
            }
        }


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
