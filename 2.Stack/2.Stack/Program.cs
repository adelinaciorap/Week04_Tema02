using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Stack
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack test = new Stack();
            
            test.Push(1);
            test.Push(2);
            test.Push(3);
            test.Push(4);
            test.Push(5);
            
            test.Print();
            
            test.Pop();
            test.Pop();
            
            Console.WriteLine();
            test.Print();
            Console.ReadKey();
        }
    }
}