using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class DemoTasks
    {
        class Person
        {
            private int ID;
            private string firstname;

            public string FirstName
            {
                get
                {
                    return firstname;
                }
                set
                {
                    firstname = value;
                }
            }

            /*public string FirstName
            {
                get
                {
                    return firstname; 
                }
                set
                {
                    firstname = value;
                }
            }*/

            public void setID(int ID)
            {
            this.ID = ID; 
            }
            public int getID()
            {
                return ID;
            }

        }
        class PropertyDemo
        {
            Person obj1 = new Person();
            //obj1.setID(1001);
            //Console.WriteLine(obj1.getID());

        }
    }
}
