using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstNonrepeatingchar
{
    class Program
    {
        readonly static int Max_Char = 256;

        static void Main(string[] args)
        {
            string s = " aabc";
            Nonrepeatingchar(s);
        }

        public static void  Nonrepeatingchar(string str)
        {
            int[] charcount = new int[Max_Char];
            LinkedList<char> ll = new LinkedList<char>();
            for(int i = 0; i <= str.Length; i++)
            {
                char CH = str[i];
                ll.AddLast(CH);
                charcount[CH - 'a']++;
                while (ll.Count > 0)
                {
                    if (charcount[ll.First.Value - 'a'] > 1)
                    {
                        ll.RemoveFirst();
                    }
                    else
                    {
                        Console.Write(ll.First.Value + " ");
                        break;

                    }
                }
                if (ll.Count == 0)
                {
                    Console.Write(-1 + " ");

                }

            }

            Console.WriteLine();

        }

    }
}
