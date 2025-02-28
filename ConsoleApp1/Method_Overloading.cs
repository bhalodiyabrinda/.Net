using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Method_Overloading
    {
        static void Add()
        {
        }
        static int Add(int a, int b)
        {
            return (a + b);
        }
        static double Add(double a, int b)
        {
            return (a + b);
        }
        static double Add(double a, double b)
        {
            return (a + b);
        }
        static int Add(int a, int b, int c)
        {
            return (a + b + c);
        }
        static void Main(string[] args)
        {
            int a=10, b=20;
            int r1 = Add(a, b);
            Console.WriteLine("a + b = {0}", r1);
        }
    }
}
