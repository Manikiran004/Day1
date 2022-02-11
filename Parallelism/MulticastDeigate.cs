using System;
using System.Collections.Generic;
using System.Text;

namespace Parallelism
{
    public delegate void Calculator(int a, int b);
    class MulticastDeigate
    {
        public void add(int a,int b)
        {
            Console.WriteLine("Addition=" + (a + b));
        }
        public void sub(int a,int b)
        {
            Console.WriteLine("Subtraction=" + (a - b));
        }
        public void mul(int a,int b)
        {
            Console.WriteLine("multiply=" + (a * b));
        }
        public void div(int a,int b)
        {
            Console.WriteLine("division=" + (a / b));
        }
        static void Main(string[] args)
        {
            MulticastDeigate m = new MulticastDeigate();
            Calculator c = new Calculator(m.add);
            c = c + m.sub;
            c = c + m.mul;
            c = c + m.div;
            c.Invoke(8, 4);
        }
    }
}
