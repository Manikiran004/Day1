using System;
using System.Collections.Generic;
using System.Text;

namespace Parallelism
{
    public delegate void Add(int a, int b);
    public delegate void Mul(int a, int b);
    public delegate void Sub(int a, int b);
    public delegate void Div(int a, int b);
    class DelegatesEx
    {
        public static void Add1(int a,int b)
        {
            Console.WriteLine("Addition is"+(a + b));
        }
        public static void Mul1(int a, int b)
        {
            Console.WriteLine("Multiplication"+(a * b));
        }
        public static void Sub1(int a, int b)
        {
            Console.WriteLine("Subtractioj="+(a -b));
        }
        public static void Div1(int a, int b)
        {
            Console.WriteLine("Division"+(a / b));
        }
        static void Main3(string[] args)
        {
            Add a = new Add(DelegatesEx.Add1);
            Sub b = new Sub(DelegatesEx.Sub1);
            Mul c = new Mul(DelegatesEx.Mul1);
            Div d = new Div(DelegatesEx.Div1);
            a(2, 3);
            b(4, 5);
            c(6, 7);
            d(2, 1);
        }
    }
}