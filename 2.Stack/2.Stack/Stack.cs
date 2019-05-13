using System;
using System.Collections.Generic;

namespace _2.Stack
{
    class Stack
    {
        private List<int> ontop = new List<int>();

        public void Push(int num)
        {
            ontop.Add(num);
        }

        public void Pop()
        {
            if (ontop.Count > 0)
                ontop.Remove(ontop.Count);
            else
                Console.WriteLine("The stack is empty.");
        }

        public void Print()
        {
            foreach (int b in ontop)
                Console.Write(b + " ");
        }
    }
}
