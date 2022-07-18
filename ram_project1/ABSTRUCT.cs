/*
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABSTRUCT
{
    abstract class person
    {
        public string n1;
        public string n2;
        public int age;
        public long phone;
        public abstract void print();

    }
    class teacher : person
    {
        public int exp;
        public int sal;
        public override void print()
        {
            string s = this.n1 + " " + this.n2;
            Console.WriteLine(" Teacher name is: {0}", s);
            Console.WriteLine(" Teacher age is: {0}", this.age);
            Console.WriteLine(" Teacher phone No is: {0}", this.phone);
            Console.WriteLine(" Teacher roll is: {0}", this.exp);
            Console.WriteLine(" Teacher fees is: {0}", this.sal);

        }
    }
    class student : person
    {
        public int roll;
        public int fees;
        public override void print()
        {
            string s = this.n1 + " " + this.n2;
            Console.WriteLine("student name is: {0}", s);
            Console.WriteLine("student age is: {0}", this.age);
            Console.WriteLine("student phone No is: {0}", this.phone);
            Console.WriteLine("student roll is: {0}", this.roll);
            Console.WriteLine("student fees is: {0}", this.fees);

        }
    }

    class program
    {
        static void Main()
        {
            // we cannot create an object of abstruct class
            // person person = new person();
            student a = new student();
            a.n1 = "RAM";
            a.n2 = "SARKAR";
            a.age = 10;
            a.phone = 9923231212;
            a.roll = 23;
            a.fees = 10000;
            a.print();
            Console.WriteLine("----------------------------------------------------");
            teacher b = new teacher();

            b.n1 = "ARKO";
            b.n2 = "ROY";
            b.age = 40;
            b.phone = 9922334456;
            b.exp = 23;
            b.sal = 70000;
            b.print();
            dynamic d = new[] { "one", "two" };

        }
    }
}*/
