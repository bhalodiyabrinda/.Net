using System;
namespace ConsoleApp1
{
    abstract class Queue
    {
        public abstract void callme();
        public void callmetoo()
        {
            Console.WriteLine("This is a concrete method.");
        }
    }
    class abc : Queue
    {
        public override void callme()
        {
            Console.WriteLine("B's implementation of callme.");
        }
    }
    class AbstractDemo
    {
        static void Main(string[] args)
        {
            abc b = new abc();
            b.callme();
            b.callmetoo();
        }
    }
}