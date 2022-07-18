/*
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structure
{
    struct employee
    {
       public int sal;
       public int age;
        public void print()
        {
            Console.WriteLine("EMPLOYEE SALERY : {0}",this.sal);
            Console.WriteLine("EMPLOYEE AGE : {0}", this.age);
        }

    }
     class program
    {
       
       
        static void Main()
        {
            employee s = new employee();

            s.sal = 10000;
            s.age = 25;
            employee s1 =s;
            employee s2 = s;
            s.sal = 20000;
            s.print();
            Console.WriteLine("------------------------------------");
            s1.print();
            Console.WriteLine("------------------------------------");
            s2.print();
            Console.WriteLine("------------------------------------");
            
        }
    }
}
*/
