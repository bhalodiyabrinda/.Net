using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class RefDemo
    {
        static void Change(ref int x, int y)
        {
            x = 110;
            y = 200;

        }
        static void Main()
        {
            int a, b;
            a = 10;
            b = 20;

            Console.WriteLine("Before change");
            Console.WriteLine(".............");
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);
            Change(ref a, b);
            Console.WriteLine("After change");
            Console.WriteLine(".............");
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);

        }
    }
}
