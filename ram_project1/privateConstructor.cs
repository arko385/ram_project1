/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace privateConstructor
{
    class example
    {
        private example()
        {

        }
        public static void getTime()
        {
            Console.WriteLine(DateTime.Now);
        }

    }

  
    //WE CANNOT INHERIT THAT CLASS BECAUSE THAT CLASS CONTAIN A PRIVATE CLASS
    *//*
    class example2 :example 
    {

    }
   *//*

    class program
    {
       static void Main()
        {
           // example p = new example(); NOT POSSIBLE TO CREATE AN INSTANCE OF THIS CLASS
           example.getTime();
        }
    }
}
*/
