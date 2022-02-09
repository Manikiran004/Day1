using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collections
{

    public class Person1
    {
        public string Name;
        public int Age;


        public override string ToString()
        {
            return Name + " - " + Age;
        }
    }
    class queueemp
    {
        static void Main(string[] args)
        {
            Queue q= new Queue();
            Person1[] p = new Person1[3];

            int total = 3;
            for (int i = 0; i < total; i++)
            {
                string name = Console.ReadLine();
                int age = int.Parse(Console.ReadLine());

                p[i] = new Person1();
                p[i].Name = name;
                p[i].Age = age;
                q.Enqueue(p[i]);

            }

            foreach (Person1 pe in q)
            {
                Console.WriteLine(pe.ToString());
            }

            Console.ReadLine();
        }
    }
}
