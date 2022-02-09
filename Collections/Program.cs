using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> d = new Dictionary<int, int>();
            int[] a = { 1, 2, 1, 2, 3, 4, 1, 2 };
            for (int i = 0; i < a.Length; i++)
            {
                if (d.ContainsKey(a[i]))
                {
                    d[a[i]] = d[a[i]] + 1;
                }
                else
                {
                    d[a[i]] = 1;
                }

            }
            foreach (var item in d)
            {
                Console.WriteLine(item.Key + "\t" + item.Value);
            }
        }
    }
}
