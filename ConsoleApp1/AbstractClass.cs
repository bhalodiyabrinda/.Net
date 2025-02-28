using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Persons
    {
        protected int Id;
        protected string Name;
        protected string City;

        public Persons(int Id, string Name, string City) 
        {
            this.Id = Id;
            this.Name = Name;   
            this.City = City;            
        }
        public Persons() 
        {

        }    
        public abstract void Display();

        public void Show()
        {
            Console.WriteLine("Call from Show meyhod");
        }
        



    }
    class Employees : Persons
    {
        int salary;
        public Employees() : base() 
        {

        }
        public Employees(int Id, string Name, string City, int Salary) : base(Id, Name, City)
        {
            this.salary = Salary;
        }
        public override void Display()
        {
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("NAME: " + Name);
            Console.WriteLine("CITY: " + City);
            Console.WriteLine("SALARY: " + salary);

        }
        public void Test()
        {
            Console.WriteLine("Call from Test method");
        }
    }
    internal class AbstractClass
    {
        static void main(string[] args) {

            Employees obj1 = new Employees();
            obj1.Show();

            Persons obj2 = new Employees();
            obj2.Display();
            obj2.Show();

            //Persons obj3 = new Persons(101,"Brinda", "Lalpur");

        }
    }
}
