using System;
public struct Cars
{
    public string model;
    public int year;
    public void set(string model,int year)
    {
        this.model = model;
        this.year = year;
    }
}
namespace structarray
{
    class Program
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("no of cars");
            int n = int.Parse(Console.ReadLine());
            Cars[] car = new Cars[n];
            for(int i = 0; i < n; i++)
            {
                car[i] = new Cars();
            }
            int min = 200000;
            int max = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("enter car {0} details", i);
                string s = Console.ReadLine();
                int y = int.Parse(Console.ReadLine());
                if (y > max)
                {
                    max = y;
                }
                if (y < min)
                {
                    min = y;
                }
                car[i].model=s;
                car[i].year = y;
            }
            for (int i = min; i <=max; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (car[j].year == i)
                    {
                        Console.WriteLine("{0}::{1}", car[j].model, car[j].year);
                    }
                }
               
            }
        }
    }
}
