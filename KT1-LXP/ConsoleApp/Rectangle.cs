using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Rectangle
    {
        private float _width;
        private float _height;

        public float Width
        {
            get{ return _width; }
            set
            {
                if(value > 0)
                {
                    _width = value;
                }
                else
                {
                    Console.WriteLine("Значение должно быть больше чем 0");
                }
            }
        }
        public float Height
        {
            get{ return _height; }
            set
            {
                if(value > 0)
                {
                    _height = value;
                }
                else
                {
                    Console.WriteLine("Значение должно быть больше чем 0");
                }
            }
        }
        public float Area()
        {
            return _width * _height;
        }

    }
    
    
    
}
