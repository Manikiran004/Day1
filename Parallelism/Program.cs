using System;
using System.Collections.Generic;
using System.Linq;

namespace Parallelism
{
    class Program
    {
        static void Main1(string[] args)
        {
            List<int> i = Enumerable.Range(1, 10).ToList();
            foreach (var item in i)
            {
                Console.WriteLine(item);
            }

        }
    }
}
