using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class AA
    {
        protected int x;
        public AA()
        {
            x = 100;  
        }
        public virtual void Display()
        {
            Console.WriteLine("Class AA : Display Method");
            Console.WriteLine("x:" + x);
        }
        public void Show()
        {
            Console.WriteLine("Class AA : Show Method" );
        }
    }
    class BB : AA
    {
        protected int y;
        public BB()
        {

            y = 200;
        }
        public void Display()
        {
            Console.WriteLine("Class BB : Display Method");
            Console.WriteLine("x:" + x);
            Console.WriteLine("y:" + y);
        }
        public void Test()
        {
            Console.WriteLine("Class BB : Test Method");
        }
    }
    internal class Method_Overriding
    {
        static void Main(string[] args)
        {
            AA obj1 = new AA();
            obj1.Display();

            BB obj2 = new BB();
            obj2.Display();

            AA obj3 = new BB();
            obj3.Display();
            obj3.Show();
        }
    }
}
