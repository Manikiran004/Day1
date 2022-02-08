using System;
using System.Text.RegularExpressions;

namespace emp
{
    class Emp
    {
        public string name;
        public float salary;
        public string eid;
        public bool get(string name, string sal, string id)
        {

            Regex r1 = new Regex("^[0-9]{4,5}$");
            Match m1 = r1.Match(sal);
            Regex r2 = new Regex("^[A-Z]{3}[0-9]{4}$");
            Match m2 = r2.Match(id);
            if (m1.Success && m2.Success)
            {
                Console.WriteLine(m2.Value);
                return true;
            }
            return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            Console.WriteLine("enter salary");
            string sal = Console.ReadLine();
            Console.WriteLine("Enter id");
            string id = Console.ReadLine();
            Emp emp = new Emp();
            if (emp.get(name, sal, id))
            {
                Console.WriteLine("success");

            }
            else
            {
                Console.WriteLine("enter in correct format");
            }

        }
    }
}
