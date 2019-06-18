using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stackusingqueue
{
    class Stack
    {
        public Queue<int> q1= new Queue<int>(); 
        public Queue<int> q2 = new Queue<int>();

        public void Push(int x)
        {

            q2.Enqueue(x);

            while (q1.Count > 0)
            {
                q2.Enqueue(q1.Peek());
                q1.Dequeue();
            }
            Queue<int> q = q1;
            q1 = q2 ;
            q2 = q;
            
        }

        public void Pop()
        {
            if (q1.Count == 0)
                return ;
            q1.Dequeue();

        }
        public int top()
        {
            if (q1.Count == 0)
                return -1;
            return (int)q1.Peek();
        }
        static void Main(string[] args)
        {
            Stack s = new Stack();
            s.Push(1);
            s.Push(2);
            s.Push(3);
         
            Console.WriteLine(s.top());
            s.Pop();
            Console.WriteLine(s.top());
            s.Pop();
            Console.WriteLine(s.top());
            Console.ReadKey();
        }
    }
}
