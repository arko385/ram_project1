
 namespace ram_project1
{
    class exp
    {
        public int i = 10;
    }

    class program3
    {
        public static void Main(String[] args)
        {
            // Logical exception handeling
            /* 
               int a, b, c;
               Console.WriteLine("ENTER a");
               a = int.Parse(Console.ReadLine());

               Console.WriteLine("ENTER b");
               b = int.Parse(Console.ReadLine());
               if(b==0)
                   Console.WriteLine("b can not be equal to 0");
               else
               {

               c = a / b;
               Console.WriteLine(c);
               }
             */
            try
            {
                int a, b, c;
                Console.WriteLine("ENTER a");
                a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("ENTER b");
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
                Console.WriteLine("A/B = "+c);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("CODE EXECUTED SUCCESSFULLY");
            }


        }
    }
}
*/
