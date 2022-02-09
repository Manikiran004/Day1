using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    public class Person
    {
        public string Name;
        public int Age;


        public override string ToString()
        {
            return Name + " - " + Age;
        }
    }
    class listex
    {
        static void Main(string[] args)
        {

            ArrayList list = new ArrayList();
            Person[] p = new Person[3];

            int total = 3;
            for (int i = 0; i < total; i++)
            {
                string name = Console.ReadLine();
                int age = int.Parse(Console.ReadLine());

                p[i] = new Person();
                p[i].Name = name;
                p[i].Age = age;
                list.Add(p[i]);
                
            }

            foreach (Person pe in list)
            {
                Console.WriteLine(pe.ToString());
            }

            Console.ReadLine();
        }
    }
}