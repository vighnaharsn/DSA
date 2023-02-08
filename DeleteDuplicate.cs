using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteDuplicate
{
    /*
     Logic : 
    
       TC: O(n)
       SC: O(n)

     */
    internal class DeleteDuplicate
    {
        static void Main(string[] args)
        {

            LinkedList<int> list = new LinkedList<int>();

            list.AddLast(4);
            list.AddLast(3);
            list.AddLast(2);
            list.AddLast(2);
            list.AddLast(1);
            list.AddLast(3);
            list.AddLast(2);
            list.AddLast(5);
            list.AddLast(4);            

            LinkedListNode<int> head = list.First;

            DelDuplciate(head);

            Console.ReadKey();
        }

        static void DelDuplciate(LinkedListNode<int> head)
        {
            Dictionary<int, int> hm = new Dictionary<int, int>();

            LinkedListNode<int> curr = head;

            /* to remove duplictae value 
            Dictionary<int, bool> hm = new Dictionary<int, bool>();

            while (curr != null)
            {
                if (!(hm.ContainsKey(curr.Value)))
                {
                    Console.Write(curr.Value + " ");
                    hm.Add(curr.Value, true);
                }

                curr = curr.Next;
            }
            */

            /* to remove all duplictae */
            while (curr != null)
            {
                if (!(hm.ContainsKey(curr.Value)))
                {
                    hm.Add(curr.Value, 1);
                }
                else
                {
                    hm[curr.Value] += 1;
                }
                curr = curr.Next;
            }

            foreach(var a in hm)
            {
                if(a.Value == 1)
                {
                    Console.Write(a.Key + " ");
                }
            }            
        }
    }
}
