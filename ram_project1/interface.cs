/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ram_project1
{
    interface i1
    {
        void show();
    }
    interface i2
    {
       void show();
    }
    class partTimeEmployee : i1,i2
    {
        // By default we use  the method overriding
     void i1.show()
        {
            Console.WriteLine("THIS IS A METHOD OF INTERFACE 1");
        }
      
        //explicite
        void i2.show()
        {
            Console.WriteLine("THIS IS A METHOD OF INTERFACE 2");

        }
      public void show()
        {
            Console.WriteLine("THIS IS A METHOD OF IT'S OWN ");
        }
    }
    class program
    {


        static void Main()
        {
          *//*partTimeEmployee p= new partTimeEmployee(); 
            ((i1)p).show();
            ((i2)p).show();
          *//*

           
             i1 p1=new partTimeEmployee();
            p1.show();
            i2 p2 = new partTimeEmployee();
             p2.show();
            partTimeEmployee p3 = new partTimeEmployee();
            p3.show();
           
           

        }
    }
}
*/