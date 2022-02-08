using System;
using System.Collections.Generic;
using System.Text;

namespace structarray
{
    class statistics
    {
        static void Main(string[] args)
        {
            double[] a = new double[1000];
            Console.WriteLine("1.Add 2.Show 3.Search 4.Statistics 5.Exit");
            int j = 0;
            int r;
            double maxi = 0;
            double mini = 1000000;
            do
            {
                r=int.Parse(Console.ReadLine());
                switch (r)
                {

                    case 1:
                        Console.WriteLine("\nENter number to insert");
                        double num = double.Parse(Console.ReadLine());
                        if (num > maxi)
                        {
                            maxi = num;
                        }
                        if (num < mini)
                        {
                            mini = num;
                        }
                        a[j] = num;
                        j++;
                        break;

                    case 2:
                        int k = 0;
                        while (a[k] > 0)
                        {
                            Console.Write(a[k] + "\t");
                            k++;
                        }
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine("\nENter number to search");
                        double v= double.Parse(Console.ReadLine());
                        int f = 0;
                        for(int m = 0; m < 1000; m++)
                        {
                            if (a[m] == v)
                            {
                                f = 1;
                            }
                        }
                        if (f == 1)
                        {
                            Console.WriteLine("\nValue is found");
                        }
                        else
                        {
                            Console.WriteLine("\nValue is not found");

                        }
                        
                        break;
                    case 4:
                        Console.WriteLine("\nTotal values stored in array are " + (j));
                        double sum = 0;
                        double avg = 0;
                        for(int m = 0; m < 1000; m++)
                        {
                            sum += a[m];

                        }
                        avg = (sum) / (j);
                        Console.WriteLine("Total sum :"+(sum));
                        Console.WriteLine("Total avg :" + (avg));
                        Console.WriteLine("max value :" + (maxi));
                        Console.WriteLine("min value :" + (mini));
                        break;
                    case 5:
                        Console.WriteLine("Exited");
                        break;
                }
                if (r != 5)
                {
                    Console.WriteLine("1.Add 2.Show 3.Search 4.Statistics 5.Exit");
                }

            } while (r!= 5);
        }
    }
}
