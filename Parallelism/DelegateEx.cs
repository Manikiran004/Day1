using System;
using System.Collections.Generic;
using System.Text;

namespace Parallelism
{
    
    class DelegateEx
    {
        public delegate string Print(string name);
        static void Main(string[] args)
        {
            Print p = delegate (string name)
              {
                  return "hello" + name;
              };
            Console.WriteLine(p("mani"));
        }
    }
}
