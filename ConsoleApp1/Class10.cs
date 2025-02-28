using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class10
    {
        static void Main(string[] args)
        {
            int[,] n = new int[3, 4];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write("Enter the number");
                    n[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
    }
}
