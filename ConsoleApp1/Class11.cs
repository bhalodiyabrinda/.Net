using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class11
    {
        static void Main(string[] args)
        {
            int[][] b = new int[3][];
            {
                b[0] = new int[3];
                b[1] = new int[2];
                b[2] = new int[4];
                for (int i = 0; i < b.Length; i++)
                {
                    int RowSum = 0;
                    for (int j = 0; j < b[i].Length; j++)
                    {
                        Console.WriteLine(" Enter n:");
                        b[i][j] = Convert.ToInt32(Console.ReadLine());
                        RowSum = RowSum + b[i][j];
                    }
                    Console.WriteLine(i + "the Row sum:" + RowSum);
                }
            }
            Console.ReadLine();
        }
    }
}
