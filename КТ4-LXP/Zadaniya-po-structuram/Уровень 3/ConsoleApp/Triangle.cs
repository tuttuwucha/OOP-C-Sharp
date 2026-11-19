using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace ConsoleApp
{
    public struct Point
    {
        public double X;
        public double Y;

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
    }

    public struct Triangle
    {
        public Point A;
        public Point B;
        public Point C;

        public Triangle(Point a, Point b, Point c)
        {
            A = a;
            B = b;
            C = c;
        }

     
        private double GetDistance(Point p1, Point p2)
        {
            double dx = p2.X - p1.X;
            double dy = p2.Y - p1.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

     
        public double CalculatePerimeter()
        {
            double a = GetDistance(B, C);
            double b = GetDistance(A, C);
            double c = GetDistance(A, B);
            return a + b + c;
        }

     
        public double CalculateArea()
        {
            double a = GetDistance(B, C);
            double b = GetDistance(A, C);
            double c = GetDistance(A, B);
            double p = (a + b + c) / 2.0;

            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}

