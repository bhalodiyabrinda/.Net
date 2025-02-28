using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Aa
    {
        public void Display()
        {
            Console.WriteLine("Display form Aa");
        }
        public virtual void Show()
        {
            Console.WriteLine("Show form Aa");
        }
    }
    sealed class Bb : Aa
    {
        public void Test()
        {
            Console.WriteLine("Test form Bb");
        }
        public new void Display()
        {
            Console.WriteLine("Display form Bb");
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine("show form Bb");
        }
    }
    class Cc : Bb
    {
        public override void Show()
        {
            Console.WriteLine("show form Cc");
        }
    }
    internal class MethodHiding
    {
        static void Main(string[] args) 
        {
            Aa a = new Aa();
            a.Display();
            a.Show();

            Bb b = new Bb();    
            b.Display(); 
            b.Show();

            Aa c = new Bb();   
            c.Display(); 
            c.Show();
        }
    }
}
