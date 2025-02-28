using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class5
    {
        static void Main(string[] args)
        {
            int n = 10;
            for (int i = 1; i <= n; i += 2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            for (int i = 2; i <= n; i += 2)
            {
                Console.Write(i + " ");
            }
        }
    }
}
