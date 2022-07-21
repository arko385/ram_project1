using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ram_project1
{
    /* Anoymus method can be assigned to a variable of deligate type
     * 
     * You need to specify the return type in anoymus method;it is interferred from the 
     * return stataement inside the method body
     * 
     * It has the same return type as the delegets
     * 
     * We don't required to use access modifiers before the anoymus function
     * 
     * Anoymus function is not a static or instance member 
     * 
     * lesser typing work because we don't need to write access modifiers,return type and name of the function
     * 
     * It cannot contain jump statement like break,goto,continue
     * 
     * Anoymus method must be assigned to a delegate, it can be pass as a parameter
     *
     */

    public delegate void del(int num);
    class program
    {
     /*   public static void incr(int num)
        {
            num += 5;
            Console.WriteLine(num);
        }*/
      
        // It is a exmple of how a anoymus method can be pass to any other method
        // To do this we have to pass the delegate
        public static void method1(del d,int a)
        {
            a += 10;
            // d(a) is the anoymus method which will increase the value of a by 5
            d(a);
        }
        static void Main()
        {
            // It is a anoymus function to increament the value by 5
            /*
              del obj = delegate(int a)
              {
                  a = a + 5;
                  Console.WriteLine(a);

              };
            */
            program.method1(delegate (int b) { b=b+5; Console.WriteLine(b); }, 10);
            


        }

    }
}
