using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ram_project1
{
    
    public class Animal
    {
        public virtual void eat()
        {
            Console.WriteLine("Eating...");
        }
    }
    public class Dog : Animal
    {
        public override void eat()
        {
            Console.WriteLine("Eating bread...");
        }
    }

   /* class program
    {

        static void Main()
        {
           Dog d=new Dog(); 
            d.eat();


        }
    }*/
}
