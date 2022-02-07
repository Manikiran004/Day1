using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class transpose
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter rows hi");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("enter cols");
            int m = int.Parse(Console.ReadLine());
            int[,] a = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int[,] b = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    b[j, i] = a[i, j];
                }
            }


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(b[i, j] + "\t");
                }
                Console.WriteLine();
            }


        }

    }
}
