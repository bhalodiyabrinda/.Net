using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    delegate void MyDelegate(int x, int y);
    class DelegateClass
    {
        static void Add(int x, int y)
        {
            Console.WriteLine(x + y); 
        }
        static void Sub(int x, int y)
        {
            Console.WriteLine(x - y);
        }
        static void Div(int x, int y)
        {
            Console.WriteLine(x * y);
        }
        static void Mul(int x, int y)
        {
            Console.WriteLine(x / y);
        }
        static void Main()
        {
            MyDelegate obj1 = new MyDelegate(Add);
            MyDelegate obj2 = new MyDelegate(Sub);
            MyDelegate obj3 = new MyDelegate(Div);
            MyDelegate obj4 = new MyDelegate(Mul);

            obj1(40, 20);
            obj2(40, 20);
            obj3(40, 20);
            obj4(40, 20);
        }
    }
}
