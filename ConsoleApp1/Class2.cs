using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            int i;
            int k = 1;
            for (i = 1; i <= 5; i++)
            {
                if (i % 2 == 0)
                {
                    int x = k + i - 1;
                    for (int j = 1; j <= i; j++)
                    {
                        Console.WriteLine(x + "  ");
                        k++;
                        x--;
                    }

                }
                else
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.WriteLine(k + "  ");
                        k++;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
