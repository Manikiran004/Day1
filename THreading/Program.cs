﻿using System;
using System.Diagnostics;
using System.Threading;
namespace THreading
{
    class Program
    {
        static void Main1(string[] args)
        {
            Thread oThread = new Thread(WorkThread);
            oThread.Start();
            oThread.IsBackground = true;
            Console.WriteLine("Main Thread Quits");
        }
        static void WorkThread()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("WOrker Thread is in progress");
                Thread.Sleep(2000);//2 second
            }

            Console.WriteLine("Thread quits");
        }
    }
}
