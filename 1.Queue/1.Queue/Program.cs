using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Queue
{
    class Program
    {
        static void Main(string[] args)
        { 
            
            Queue inline = new Queue();
            inline.Enqueue("Maria");
            inline.Enqueue("Ana");
            inline.Enqueue("Dan");
            inline.Enqueue("Gigi");

            inline.Dequeue();

            inline.Print();
            
        }
        
    }
   

}
