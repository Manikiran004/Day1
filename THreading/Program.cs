using System;
using System.Threading;
namespace THreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(Run);
            t.Start();
            t.Join();
            Console.WriteLine("iN main method");
        }
        static void Run()
        {
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("running");
            }
        }
    }
}
