using System;
using System.IO;
using System.Text;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            /* StreamWriter s = new StreamWriter("C://Users//Dell//Desktop//Git//File-Handler//sample");
             s.WriteLine("Hello...THis is sample file");
             s.Flush();
             s.Close(); */
            StreamReader s = new StreamReader("C://Users//Dell//Desktop//Git//File-Handler//hi.txt");
            string s1 = s.ReadLine();
            string rev = "";
            for(int i = s1.Length-1; i >= 0; i--)
            {
                rev += s1[i];
            }
            if (rev == s1)
            {
                Console.WriteLine("palindrome="+rev);
            }
            else
            {
                Console.WriteLine("not palindrome="+s1);
            }
        }
    }
}
