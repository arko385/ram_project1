using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ram_project1
{
     class emp
    {
        int[] age=new int[3];
        string[] num = new string[3];
        public int this[int index]
        {
            set
            {
                if(index>=0 && index<age.Length)
                {
                    if(value>0)
                    age[index]=value;
                    else
                    Console.WriteLine("Enter a valid age !");

                }
                else
                Console.WriteLine("Enter a valid Index !");

            }
            get
            {  
            return age[index];
            }
        }

     

    }

    class program
    {
        static void Main()
        {
            emp a=new emp();
            a[0] = 10;
           
            Console.WriteLine(a[0]);

        }
    }
}
