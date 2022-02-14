using System;
using System.Text.RegularExpressions;

namespace ProgramsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int v = 0, c = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if ((Char.ToLower(s[i]) == 'a')|| (Char.ToLower(s[i]) == 'e')|| (Char.ToLower(s[i]) == 'i')|| (Char.ToLower(s[i]) == 'o')|| (Char.ToLower(s[i]) == 'u'))
                {
                    v++;

                }
                else
                {
                    c++;
                }

            }


            Console.WriteLine("vowels:" + v);
            Console.WriteLine("consonants:" + c);
        }
    }
}
