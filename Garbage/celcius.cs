using System;
using System.Collections.Generic;
using System.Text;

namespace Garbage
{
    class celcius
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter in celcius");
            double c = Convert.ToDouble(Console.ReadLine());
            double kelvin = c + 273;
            double fahrenheit = c * 1.8 + 32;
            Console.WriteLine("celcius to kevin is " + kelvin);
            Console.WriteLine("celcius to fahrenheit is " + fahrenheit);
        }
    }
}
