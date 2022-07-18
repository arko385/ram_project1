using System;
namespace ram1
{
    public class cbr
    {
        public void show1(ref int val)
        {
             val = val * val;
            Console.WriteLine("INSIDE THE SHOW FUNCTION : " + val);
        }

    }

}