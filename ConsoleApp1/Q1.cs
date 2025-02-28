/*
 Write a program to convert given name in upper characters.
INPUT: John F Kennedy
OUTPUT: JOHN F KENNEDY
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Q1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a name:");
            string name = Console.ReadLine();
            string upperName = name.ToUpper();
            Console.WriteLine("Output: " + upperName);
            Console.ReadLine();
        }
    }
}

