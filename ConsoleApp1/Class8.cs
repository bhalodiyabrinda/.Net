using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class8
    {
        static void Main(string[] args)
        {
            int[] n = new int[5];
            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine("Enter the number:");
                n[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\nArray Elements");
            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine(n[i]);
            }

        }
    }
}
