using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class OutDemo
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="outdemo"></param>
        /// <param ="y"></param>
        /// <param name="z"></param>
        static void Change(out int x,out int y, out int z)
        {
            x = 110;
            y = 200;
            z = 300;
        }
        static void Main()
        {
            int a, b, c;
            a = 10;
            b = 20;
            c = 30;

            Console.WriteLine("Before change");
            Console.WriteLine(".............");
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);
            Console.WriteLine("c=" + c);

            Change(out a,out b, out c);
            Console.WriteLine("After change");
            Console.WriteLine(".............");
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);
            Console.WriteLine("c=" + c);
        }
    }
}
