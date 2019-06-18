using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueusingStack
{
    class Queue
    {
        public Stack<int> stack1 = new Stack<int>();
        public Stack<int> stack2 = new Stack<int>(); 

        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            Console.Write(q.Dequeue() + " ");
            Console.Write(q.Dequeue() + " ");
            Console.Write(q.Dequeue());
            Console.ReadKey();
        }
        public  void Enqueue(int x)
        {
            stack1.Push(x);
        }
        public int Dequeue()
        {
            if(stack1.Count==0 && stack2.Count == 0)
            {
                Console.WriteLine("queue is empty");
            }
            if (stack2.Count == 0)
            {
                while (stack1.Count > 0)
                {
                    stack2.Push(stack1.Pop());
                }
            }
            int x = stack2.Pop();
            return x;
        }
     
    }
}
