using System;
using System.IO;

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
            StreamReader s = new StreamReader("C://Users//Dell//Desktop//Git//File-Handler//sample");
            string s1=s.ReadLine();
            while (s1 != null)
            {
                Console.WriteLine(s1);
                s1 = s.ReadLine();
                
            }
            s.Close();
        }
    }
}
