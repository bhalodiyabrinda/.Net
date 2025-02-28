using System;

namespace ConsoleApp1
{
    internal class Q2
    {
        static void Main(string[] args)
        {
            int a, b, c, result;
            Console.Write("Enter Number 1: ");
            // Read input for the first number
            string str = Console.ReadLine();
            a = Convert.ToInt32(str);

            Console.Write("Enter Number 2: ");
            // Read input for the second number
            str = Console.ReadLine();
            b = Convert.ToInt32(str);

            Console.Write("Enter Number 3: ");
            // Read input for the third number
            str = Console.ReadLine();
            c = Convert.ToInt32(str);

            // Calculate the sum
            result = Sum(a, b, c);

            // Display the result
            Console.WriteLine("The sum is: " + result);

            Console.Read();
        }

        static int Sum(int x, int y, int z)
        {
            int res;
            res = x + y + z;
            return res;
        }
    }
}
