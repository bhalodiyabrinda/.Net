using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class9
    {
        static void Main(string[] args)
        {
            int[] n = new int[5];
            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine("Enter the number:");
                n[i] = Convert.ToInt32(Console.ReadLine());
            }

            int Even = 0;
            int Odd = 0;
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] % 2 == 0)
                {
                    Even += n[i];
                }
                else
                {
                    Odd += n[i];
                }
            }

            Console.WriteLine("\nArray Elements:");
            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine(n[i]);
            }

            Console.WriteLine("\nSum of even numbers: " + Even);
            Console.WriteLine("Sum of odd numbers: " + Odd);
        }
    }
}
