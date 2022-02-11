using System;
using System.Collections.Generic;
using System.Text;

namespace Parallelism
{
    class GenericDelegates
    {
        static void Main(string[] args)
        {
            Func<int,int,int> f1 = (x,y) => { return x + y; };
            Console.WriteLine(f1(2, 3));
            Action<int, int> f2 = (x, y) => { Console.WriteLine(x + y); };
            f2(5, 6);
            Predicate<string> f3 = (x) => { if (x.Length > 5)
                {
                    return true;
                }
                return false;
            };
            Console.WriteLine(f3("ram"));
            

              

       
        }
    }
}
