using System;
using System.Collections.Generic;
using System.Text;

namespace structarray
{
    class palindrome
    {
        static bool palin(string s,int i,int j)
        {
            if (i>=j)
            {
                return true;
            }
            else
            {
                return s[i]==s[j] && palin(s, i + 1, j - 1);
            }
            
        }
        static void Main2(string[] args)
        {
            string s = Console.ReadLine();
            if (palin(s,0,s.Length-1))
            {
                Console.WriteLine("palindrome");
            }
            else
            {
                Console.WriteLine("not palindrome");
            }
        }
    }
}
