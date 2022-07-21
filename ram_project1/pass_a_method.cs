using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ram_project1
{
    // pass a method using delegates 
    // a*a+a i will do this
    // in show function i will pass the value of 'a' and also the delegate
    // the delegate has a function pow which will return a*a
    public delegate int del(int a);
    class program
    {
        public static int pow1(int a)
        {
             int k, r=1;
            k = a;
            while(k>0)
            {
                r = r * a;
                k--;
            }
            return r;
        }
        public  static void show(del d,int a)
        {
            int z = d(a) + a;
            Console.WriteLine(z);
        }
        static void Main()
        {
            del q = new del(pow1);
            program.show(q, 3);
        }
    }
   
}
