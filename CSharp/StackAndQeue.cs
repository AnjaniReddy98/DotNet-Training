using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQeue
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stack and Qeue Data Structures
            //Stack is Last in First out where as qeue is First in First out(FIFO) data structures
            Stack<float> fnumbers = new Stack<float>();
            fnumbers.Push(10.90f);
            fnumbers.Push(12.53f);
            fnumbers.Push(13.95f);
            fnumbers.Push(15.98f);

            foreach (var fn in fnumbers)
                Console.WriteLine(fn);

            fnumbers.Pop();

            Console.WriteLine("\nAfter calling the pop method");

            foreach (var fn in fnumbers)
                Console.WriteLine(fn);

            Queue<double> qnumbers = new Queue<double>();
            qnumbers.Enqueue(10.98);
            qnumbers.Enqueue(13.85);
            qnumbers.Enqueue(12.98);
            qnumbers.Enqueue(14.98);
            Console.WriteLine("\nBefore calling the dequeue method");
            foreach (var qn in qnumbers)
                Console.WriteLine(qn);

            qnumbers.Dequeue();

            Console.WriteLine("\nAfter calling the dequeue method");

            foreach (var qn in fnumbers)
                Console.WriteLine(qn);
            Console.ReadLine();
        }
    }
}
