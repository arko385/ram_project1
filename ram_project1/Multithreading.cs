using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ram_project1
{
    class program
    {
        private static object locker1 = new object();
        static ManualResetEvent _mre = new ManualResetEvent(false);
        public static void func1()
        {
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("Func1: " + i);
            }
        }

        public static void func2()
        {
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("Func2: " + i);
                if (i == 25)
                {
                    Thread.Sleep(8000);
                    Console.WriteLine(" Wait for 8 sec");
                }
            }
        }

        public static void func3()
        {
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("Func3: " + i);
            }
        }

        public static void Dowork()
        {

            lock (locker1)
            {
                Console.WriteLine($"Thread{Thread.CurrentThread.ManagedThreadId} starting..");
                Thread.Sleep(2000);
                Console.WriteLine($"Thread{Thread.CurrentThread.ManagedThreadId} completed..");
            }
        }

        public static void Dowork1()
        {

            try
            {
                Monitor.Enter(locker1);
                Console.WriteLine($"Thread{Thread.CurrentThread.ManagedThreadId} starting..");
                Thread.Sleep(2000);
                throw new Exception();
                Console.WriteLine($"Thread{Thread.CurrentThread.ManagedThreadId} completed..");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("completed !-------");
                Monitor.Exit(locker1);

            }
        }

        public static void Write()
        {
            Console.WriteLine($"Thread{Thread.CurrentThread.ManagedThreadId} writing.....");
            _mre.Reset();
            // Thread.Sleep(4000);
            Console.WriteLine($"Thread{Thread.CurrentThread.ManagedThreadId} writing completed.....");
            _mre.Set();

        }

        public static void Read()
        {
            Console.WriteLine($"Thread{Thread.CurrentThread.ManagedThreadId} waiting.....");

            _mre.WaitOne();
            // Thread.Sleep(4000);
            Console.ReadLine();
            Console.WriteLine($"Thread{Thread.CurrentThread.ManagedThreadId} reading completed.....");

        }




        static void Main()
        {
            // In single thread method everything will happen sequentially
            // after f1, it will complete f2 then f3 
            // here we though sleep the thread for 8 sec but after complete the work of f2 it will 
            // complete the f3


            // program.func1();
            // program.func2();
            // program.func3();

            //----------------------------------------------------------------------------------------
            #region threaduse
            //----------------------------------------------------------------------------------------------

            // when one thread sleep such that the work is not stop so we use multithreading concept
            // here though we sleep the thread 2 but the work not stop in this time period 
            // another thread will be run


            // Thread t1=new Thread(func1);
            // Thread t2=new Thread(func2);    
            // Thread t3=new Thread(func3);
            // t1.Start();
            // t2.Start(); 
            // t3.Start();

            //-----------------------------------------------------------------------------------------------
            #endregion

            #region lock
            // lock keyword : it will run the thread sequentially


            // we use this when we need that after one thread completed another will run
            // if we  use lock then after one completed than another one started though the thread is 
            //sleep for few seconds

            // if we don't use the lock then when a thread is sleep another thread will be run such 
            // that no time is waste

            // for (int i = 0; i < 4; i++)
            //  {
            //      new Thread(Dowork).Start(); 

            //  }
            //------------------------------------------------------------------------------------
            #endregion

            #region Monitor

            //------------------------------------------------------------------------------------------------
            // Monitor keyword  : this will same as how lock keyword use but we can use this in a try block
            // by this though there a exception in the code it will run

            //   for (int i = 0; i < 4; i++)
            //     {
            //           new Thread(Dowork1).Start(); 
            //
            //     }

            //----------------------------------------------------------------------------------
            #endregion

            //---------------------------------------------------------------------------------
            // Manual Reset event

            new Thread(Write).Start();
            for (int i = 0; i < 5; i++)
            {
                new Thread(Read).Start();

            }






        }
    }
}
