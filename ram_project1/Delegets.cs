using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ram_project1
{
    public delegate void calculate(int a, int b);
    public delegate void calculate2(int a);
    public delegate void show_deligate();
    class program
    {
        public void add(int a, int b)
        {
            int r = a + b;
            Console.WriteLine("Addition result is : {0}", r);
        }

        public static void sub(int a, int b)
        {
            int r = a - b;
            Console.WriteLine("Subtraction result is : {0}", r);
        }
        public static void Mul(int a, int b)
        {
            int r = a * b;
            Console.WriteLine("Multiplication result is : {0}", r);
        }

        public static void div(int a, int b)
        {
            int r = a / b;
            Console.WriteLine("division result is : {0}", r);
        }

        public static void show()
        {
            Console.WriteLine("THIS IS A SHOW METHOD !");
        }
        public static void square(int num)
        {
            int r = num * num;
            Console.WriteLine(" square OF {0}  equal to : {1}", num, r);
        }

        public static void qube(int num)
        {
            int r = num * num * num; ;
            Console.WriteLine(" Qube OF {0}  equal to  : {1}", num, r);
        }
        static void Main()
        {
            // Delegets is a class , used to pass a method as a parameter of another method
            program a = new program();
            // To use delegets we have to create the object of it and also we have to pass the method
            // To pass the method we have to create the object of the program by this way we can only access 
            // the method , but if the methods are static then we don't have any need to create a object we can
            //  directly use the method by the class
            // exp-1 the the method is non-static
            calculate obj1 = new calculate(a.add);
            obj1(20, 40);
            // exp-2 If the method is static we can directly use the method don't need to create 
            // any object of the program class
            calculate obj2 = new calculate(sub);
            obj2(30, 20);
            calculate obj3 = new calculate(Mul);
            obj3(10, 20);
            calculate obj4 = new calculate(div);
            obj4(30, 10);
            // Multicast deligates
            show_deligate obj5 = new show_deligate(show);
            obj5();
            calculate2 obj6 = new calculate2(square);
            obj6(12);
            calculate2 obj7 = new calculate2(qube);
            obj7(5);
        }
    }
}
