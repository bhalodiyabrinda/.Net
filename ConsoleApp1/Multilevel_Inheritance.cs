using System;

namespace ConsoleApp1
{
    class a 
    {
        protected int x;
        public int y; 
    }

    class b : a 
    {
        protected int z;

        public void SetData()
        {
            x = 10;
            y = 20;
            z = 30;
        }
    }

    class c : b
    {
        public int w;

        public void SetMoreData()
        {
            w = 40;
        }

        public void DisplayData()
        {
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            Console.WriteLine("z = " + z);
            Console.WriteLine("w = " + w);
        }
    }

    internal class MultilevelInheritance
    {
        static void Main(string[] args)
        {
            c obj = new c();
            obj.SetData();
            obj.SetMoreData();
            obj.DisplayData();
        }
    }
}
