﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class7
    {
        static void Main(string[] args)
        {
            int n = 10;
            for (int i = 1; i <= n; i += 2)
            {
                Console.WriteLine();

                Console.Write(i + " ");
            }
            for (int i = 2; i <= n; i += 2)
            {
                Console.WriteLine();

                Console.Write(i + " ");
            }
        }
    }
}
