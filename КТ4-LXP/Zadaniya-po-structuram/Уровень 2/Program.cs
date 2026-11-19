using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.ReadLine();
        }
        
    }
    public struct ComplexNumber
    {
        public double Real;
        public double Imag;

        public ComplexNumber(double real, double imag)
        {
            Real = real;
            Imag = imag;
        }

        public ComplexNumber Add(ComplexNumber secondNumber)
        {
            return new ComplexNumber(this.Real + secondNumber.Real, this.Imag + secondNumber.Imag);
        }
        public ComplexNumber Substract(ComplexNumber secondNumber)
        {
            return new ComplexNumber(this.Real - secondNumber.Real, this.Imag - secondNumber.Imag);
        }
        public ComplexNumber Multiply(ComplexNumber secondNumber)
        {
            double real = this.Real * secondNumber.Real - this.Imag * secondNumber.Imag;
            double imag = this.Real * secondNumber.Imag + this.Imag * secondNumber.Real;
            return new ComplexNumber(real, imag);
        }
    }
    public struct ColorRGB
    {
        public int R;
        public int G;
        public int B;

        public ColorRGB(int r, int g, int b)
        {
            R = r;
            G = g;
            B = b;
        }

        public string ToHex()
        {
            return $"#{R.ToString("X2")}{G.ToString("X2")}{B.ToString("X2")}";
        }
    }

    public struct SimpleDate
    {
        public int Day;
        public int Month;
        public int Year;

        public SimpleDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public bool IsLeapYear()
        {
            if(Year % 400 == 0 || (Year % 4 == 0 && !(Year % 100 == 0)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}