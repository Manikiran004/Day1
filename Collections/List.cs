using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    class List
    {
        static void Main2(string[] args)
        {
            List<int> a = new List<int>();
            a.Add(2);
            a.Add(3);
            a.Add(10);
            a.Add(1);
            a.Add(4);
            a.Sort();
            Console.WriteLine("Afer sorting");
            foreach (var i in a)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            a.Remove(10);
            Console.WriteLine("after removing");
            foreach (var i in a)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            a.RemoveAt(1);
            Console.WriteLine("after removing at index i");
            foreach (var i in a)
            {
                Console.Write(i + " ");
            }
        }

    }
}
