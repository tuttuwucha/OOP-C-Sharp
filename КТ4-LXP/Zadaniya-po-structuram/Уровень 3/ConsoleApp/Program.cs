using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector2D v1 = new Vector2D(3, 4);
            Vector2D v2 = new Vector2D(1, 2);

            Console.WriteLine("Длина вектора v1: " + v1.Length());
            Console.WriteLine("Скалярное произведение: " + v1.Dot(v2));

            v1.Normalize();
            Console.WriteLine("Нормализованный v1: X = " + v1.X + ", Y = " + v1.Y);

            Money m1 = new Money(10, 75);
            Money m2 = new Money(5, 50);

            Money sum = m1.Add(m2);
            Money diff = m1.Subtract(m2);

            Console.WriteLine("Сумма денег: " + sum.Rubles + " руб. " + sum.Kopecks + " коп.");
            Console.WriteLine("Разность денег: " + diff.Rubles + " руб. " + diff.Kopecks + " коп.");
            Console.WriteLine("m1 > m2: " + m1.IsGreaterThan(m2));
            Console.WriteLine("m1 < m2: " + m1.IsLessThan(m2));

            Point p1 = new Point(0, 0);
            Point p2 = new Point(4, 0);
            Point p3 = new Point(0, 3);
            Triangle triangle = new Triangle(p1, p2, p3);

            Console.WriteLine("Периметр треугольника: " + triangle.CalculatePerimeter());
            Console.WriteLine("Площадь треугольника: " + triangle.CalculateArea());

            Point3D point3d1 = new Point3D(1, 2, 3);
            Point3D point3d2 = new Point3D(4, 6, 3);

            Console.WriteLine("Расстояние в 3D: " + point3d1.DistanceTo(point3d2));
        }
    }
}
