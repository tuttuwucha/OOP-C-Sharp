using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public struct Vector2D
    {
        public double X{ get; set; }
        public double Y{ get; set; }

        public Vector2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double Length()
        {
            return Math.Sqrt(X*X + Y*Y);
        }

        public void Normalize()
        {
            double length = this.Length();
            if(length == 0)
            {
                return;
            }
            this.X = this.X / length;
            this.Y = this.Y / length;
        }

        public double Dot(Vector2D second)
        {
            return this.X * second.X + this.Y * second.Y;
        }
    }
}
