/*
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace staticConstructor
{
     class student1
    {
        int age;
        string name;
       static student1()
        {
            Console.WriteLine("STATIC CONSTRUCTER INVOKED !");
        }
        public student1(int age, string name)
        {
            Console.WriteLine("PUBLIC CONSTRUCTER INVOKED !");
            this.age = age;
            this.name = name;
            Console.WriteLine("NAME: {0}",this.name);
            Console.WriteLine("AGE: {0}", this.age);
        }
    }
    class program
    {
        static void Main()
        {
            student1 s=new student1(10,"ram");
            student1 s2 = new student1(11,"sam");
        }
    }
}
*/