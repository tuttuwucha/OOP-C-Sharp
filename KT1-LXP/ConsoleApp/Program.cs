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

        static void ChangeBookTitle(ref Book b, string newTitle)
        {
            b.Title = newTitle;
        }

        static void ReassignBook(ref Book b)
        {
            b = new Book();
            b.Title = "Груз 200";
            b.Pages = 200;
        }

        static void Main(string[] args)
        {
            Book b = new Book();
            b.Title = "";
            b.Pages = 500;
            b.PrintInfo();

            ChangeBookTitle(ref b, "Идиот");
            b.PrintInfo();
            ReassignBook(ref b);
            b.PrintInfo();

            Rectangle r = new Rectangle();
            r.Width = 5;
            r.Height = 10;
            Console.WriteLine($"Площадь: {r.Area()}");

            Student s = new Student();
            s.Name = "Иван";
            s.Grade = 5;
            s.Print();

            Box<int> box1 = new Box<int>();
            box1.Put(42);
            Box<string> box2 = new Box<string>();
            box2.Put("Братуха");

            Console.WriteLine(box1.ToString());
            Console.WriteLine(box2.ToString());
        }
    }
}
