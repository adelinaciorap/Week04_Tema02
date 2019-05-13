using System;
using System.Collections.Generic;

namespace _1.Queue
{
    class Queue
    {
        private List <string> myqueue = new List <string>();

        public void Enqueue(string order)
        {
            myqueue.Add(order);
        }

        public void Dequeue()
        {
            if (myqueue.Count >0)
            { 
                myqueue.RemoveAt(0);
            }
            else
                Console.WriteLine("The queue is empty");

        }
        public void Print()
        {
            foreach (string a in myqueue)
            {
                Console.WriteLine(a + ",");
            }
        }
        

    }

    
}
