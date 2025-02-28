using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
    class Person  //9 data members
    {
        protected int id;
        protected string name;
        protected int age;
        protected string address;
        protected string city;
        protected string state;
        protected string country;
        protected string mobile;
        protected string email;

        //private members can not be inherited
        //protected and public members can inherited
    }
    class Employee : Person    //2 data mumbers
    {
        string designation;
        string salary;

        void GetData() 
        {
        
        }
    }
    internal class InheritanceDemo
    {

    }
}
