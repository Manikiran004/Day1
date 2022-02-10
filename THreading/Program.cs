using System;
using System.Diagnostics;
using System.Threading;
namespace THreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stwatch = new Stopwatch();
            stwatch.Start();

            Thread oThread = new Thread(ProcessSleep);
            oThread.Start();
            oThread.Join();
            stwatch.Stop();
            TimeSpan ts = stwatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}", ts.Hours, ts.Minutes, ts.Seconds);
            Console.WriteLine(elapsedTime);
            Console.WriteLine("WOrk completed");
        }
        static void Run()
        {
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("running");
            }
        }
        static void ProcessSleep()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Work in progress");
                Thread.Sleep(4000);//4 second
            }
        }
    }
}
