using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    using System;

    namespace ConsoleApp1
    {
        class A 
        {
            protected int x;
            public int y;  
        }

        class B : A 
        {
            protected int z;

            public void SetDataB()
            {
                x = 10;
                y = 20;
                z = 30;
            }

            public void DisplayDataB()
            {
                Console.WriteLine("Class B:");
                Console.WriteLine("x = " + x);
                Console.WriteLine("y = " + y);
                Console.WriteLine("z = " + z);
            }
        }

        class C : A 
        {
            public int w;

            public void SetDataC()
            {
                x = 40;
                y = 50;
                w = 60;
            }

            public void DisplayDataC()
            {
                Console.WriteLine("Class C:");
                Console.WriteLine("x = " + x);
                Console.WriteLine("y = " + y);
                Console.WriteLine("w = " + w);
            }
        }

        internal class Hierarchical_Inheritance
        {
            static void Main(string[] args)
            {
                B objB = new B();
                objB.SetDataB();
                objB.DisplayDataB();

                C objC = new C();
                objC.SetDataC();
                objC.DisplayDataC();
            }
        }
    }
}
