﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace THreading
{
    class Lockex
    {

        static readonly object plock = new object();
        static void PrintInformation()
        {
            //it will make other thread to wait until the process inside lock is completed
            lock (plock)
            {
                for (int i = 0; i <= 4; i++)
                {
                    Console.WriteLine("Value of i {0}", i);
                    Thread.Sleep(1000);
                }
            }
        }

        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(PrintInformation));
            Thread t2 = new Thread(new ThreadStart(PrintInformation));
            t1.Start();
            t2.Start();
            Console.ReadLine();
        }
    }
}
