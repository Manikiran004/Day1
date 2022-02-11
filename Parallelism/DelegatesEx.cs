using System;
using System.Collections.Generic;
using System.Text;

namespace Parallelism
{
    public delegate void Add(int a, int b);
    class DelegatesEx
    {
        public static void Add1(int a,int b)
        {
            Console.WriteLine(a + b);
        }
        static void Main(string[] args)
        {
            Add a = new Add(DelegatesEx.Add1);
            Add1(2, 3);
        }
    }
}