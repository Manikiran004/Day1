using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Collections
{
    
    class Array
    {
       

        static void Main4(string[] args)
        {
            List<string> l = new List<string>();
            List<string> l1 = new List<string>();
            l1.Add("mango");
            l1.Add("banana");
            l1.Add("dog");
            foreach(var i in l1)
            {
                l.Add(i.ToUpper());
            }
            
            foreach(var item in l)
            {
                Console.WriteLine(item);

            }


        }
    }
}
