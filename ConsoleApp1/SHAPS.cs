using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class shaps
    {
        public virtual int CalulateArea()
        {
            return 1;
        }
    }
    class square : shaps
    {
        int h;
        public square(int h) 
        {
            this.h = h;
        }
        public virtual int CalulateArea()
        {
            return (2*h);
        }
    }
    class rect : shaps
    {
        int h, w;
        public rect(int h, int w)
        {
            this.h = h;
            this.w = w;
        }
        public virtual int CalulateArea()
        {
            return (h * w);
        }
    }
     internal class SHAPS
     {
        static void main(string[] args) 
        {
            square s1 = new square(10);
            Console.WriteLine(s1.CalulateArea());

            rect s2 = new rect(10,20);
            Console.WriteLine(s2.CalulateArea());
        }

     }
}
