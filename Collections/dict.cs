using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    class dict
    {
        static void Mai3n(string[] args)
        {
            string s = Console.ReadLine();
            Dictionary<char, int> d = new Dictionary<char, int>();
            for(int i = 0; i < s.Length; i++)
            {
                if (d.ContainsKey(s[i]))
                {
                    d[s[i]] = d[s[i]] + 1;
                }
                else
                {
                    d[s[i]] = 1;
                }
            }
            foreach(var i in d)
            {
                Console.WriteLine("{0}::{1}", i.Key, i.Value);
            }

        }
    }
}