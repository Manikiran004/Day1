using System;
using System.Text;

namespace Collections
{
    class Queue1
    {
        public int[] a;
        public int pos;
        public Queue1(int n)
        {
            a = new int[n];
        }
        public void enque(int ele)
        {
            a[pos%(a.Length)] = ele;
            pos++;

        }
        int j = 0;
        public void deque()
        {
            Console.WriteLine("dequed element is " + a[j]);
            a[j % (a.Length)] = 0;   
            j++;
        }
    }
    class queueex
    {
        static void Main5(string[] args)
        {
            Console.WriteLine("emter the size of array");
            int s = int.Parse(Console.ReadLine());
            Queue1 q = new Queue1(s);
            q.enque(2);
            q.enque(4);
            q.enque(3);
            q.deque();
            q.deque();
        }
    }
}