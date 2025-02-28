using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class X
    {
        protected int a;
        public  X (){ 
        }
        public X(int a)
        {
            this.a = a;
        }
    }
    class Y:X
    {
        protected int b;
        protected int c;
        public Y(int a, int b, int c) : base(a)
        {
            this.b = b;
            this.c = c;
        }
    }
    class Z:Y
    {
         int d;
         int e;
         int f;
        public Z(int a, int b, int c, int d,int e, int f) :  base(a,b,c) 
        {
            this.d = d;
            this.e = e;
            this.f = f; 
        }
        public void Display()
        {
            Console.WriteLine("a:{0}",a);
            Console.WriteLine("b:{0}",b);
            Console.WriteLine("c:{0}",c);
            Console.WriteLine("d:{0}",d);
            Console.WriteLine("e:{0}",e);
            Console.WriteLine("f:{0}",f);

        }
    }
    internal class Constuctors_Inheritance
    {
        static void Main(string[] args)
        {
            Z obj = new Z(1,2,3,4,5,6 );
            obj.Display();
        }
    }
}
