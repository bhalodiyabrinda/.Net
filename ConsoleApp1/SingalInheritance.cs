using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void SetData()
        {
            x = 10;
            y = 20;
        }
        public void DisplayData()
        {
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
        }
    }
    
    internal class SingalInheritance
    {
        static void Main(string[] args)
        {
            B obj = new B();
            obj.SetData();
            obj.DisplayData();
        }
    }
}
