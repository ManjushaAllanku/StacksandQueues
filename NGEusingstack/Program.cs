using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGEusingstack
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 12, 5, 8, 3, 10, 4, 2 };

        
            NGE(a);
            Console.ReadKey();
        }

        public static void NGE(int[] arr)
        {
            Stack<int> stack1 = new Stack<int>();
            int element = arr[0];
            int next;
            stack1.Push(arr[0]);
            for (int i = 1; i <= arr.Length - 1; i++)
            {

                next = arr[i];
                if (stack1.Count!= 0)
                {
                    element = stack1.Pop();
                    while (element < next)
                    {
                        Console.WriteLine( element+ " next greater elemnet is " + next);
                        if (stack1.Count == 0)
                        {
                            break;
                        }
                        element = stack1.Pop();
                    }
                    if (element > next)
                    {
                        stack1.Push(element);
                    }
                }
                stack1.Push(next);

            }

            while (stack1.Count != 0)
            {
                element = stack1.Pop();
                next = -1;
                Console.WriteLine(element + "next greater element is " + next);
            }   
               

            
        }
       
    }
}
