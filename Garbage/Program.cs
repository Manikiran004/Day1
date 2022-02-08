using System;

namespace Garbage
{
    class Program
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Enter first number");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int n2 = Convert.ToInt32(Console.ReadLine());
            if(n1==0 || n2 == 0)
            {
                if (n1 == 0)
                {
                    Console.WriteLine("Entered 0 as first number");
                }
                else
                {
                    Console.WriteLine("Entered 0 as second number");
                }

            }
            else
            {
                Console.WriteLine("Division of two numbers is " + (n1 / n2));
            }
        }
    }
}
