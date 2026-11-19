using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Book
    {
        public string Title;
        private int _pages = 1;
        public int Pages
        {
            get{return _pages;}
            set
            {
                if(value >= 1)
                {
                    _pages = value;
                }
                else
                {
                    Console.WriteLine("Значение должно быть ≥ 1");
                }
            }

        }
        public void PrintInfo()
        {
            Console.WriteLine($"Книга: {Title}, страниц: {_pages}");
        }
    }
    
    
}
