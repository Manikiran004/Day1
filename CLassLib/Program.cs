using System;
using Calculator;

namespace CLassLib
{
    class Program
    {
        static void Main(string[] args)
        {
            Calcu c = new Calcu();
            Console.WriteLine(c.Add(2, 3));
        }
    }
}
