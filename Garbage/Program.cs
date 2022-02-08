﻿using System;

namespace Garbage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("the generation are " + GC.GetTotalMemory(false));
            Program p = new Program();
            Console.WriteLine("the generation are " + GC.MaxGeneration);
            Console.WriteLine("the generation are " + GC.GetGeneration(p));
            Console.WriteLine("the generation are " + GC.GetTotalMemory(false));


            GC.Collect();
            Console.WriteLine("GC in generation 0 {0}", GC.CollectionCount(0));
        }
    }
}
