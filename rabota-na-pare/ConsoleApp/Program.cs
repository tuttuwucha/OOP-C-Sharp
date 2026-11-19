using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        unsafe static void Main(string[] args)
        {
            int x = 42;
            int* px = &x;
            Console.WriteLine((ulong)(px));
            *px = 123;
            Console.WriteLine(x);

            int** ptrToPtr = &px;
            int*** ptrToPtrToPtr = &ptrToPtr;
            ***ptrToPtrToPtr = 67;
            Console.WriteLine(x);
        }
    }
}
