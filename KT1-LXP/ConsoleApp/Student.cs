using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Student
    {
        public string Name;
        private int _grade;
        public int Grade
        {
            get{ return _grade; }
            set
            {
                if(value >= 1 && value <= 5)
                {
                    _grade = value;
                }
                else
                {
                    Console.WriteLine("Значение должно быть в диапазоне 1-5");
                }
            }
        }
        public void Print()
        {
            Console.WriteLine($"Студент: {Name}, оценка: {Grade}");
        }
    }
}
