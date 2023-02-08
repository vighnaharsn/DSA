using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenList
{
    class OddEvenList
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();

            list.AddLast(2);
            list.AddLast(1);
            list.AddLast(3);
            list.AddLast(5);
            list.AddLast(6);
            list.AddLast(4);
            list.AddLast(7);
            list.AddLast(8);

            LinkedListNode<int> head = list.First;

            foreach (int a in list)
            {
                Console.Write(a + " ");
            }
            
            Console.WriteLine();

            OddEvenLst(head);

            Console.ReadKey();
        }
        static void OddEvenLst(LinkedListNode<int> head)
        {
            if(head == null || head.Next == null)
            {
                return;
            }

            LinkedListNode<int> oddList  = head;
            LinkedListNode<int> CurOdd   = head;
            LinkedListNode<int> EvenList = head.Next;
            LinkedListNode<int> CurEven  = head.Next;            

            while(CurEven.Next != null)
            {
                Console.Write(CurOdd.Value + " ");

                CurEven = CurOdd.Next;
                if(CurEven != null)
                {
                    CurOdd = CurEven.Next;
                }
                else
                {
                    break;
                }
            }
            while (oddList.Next != null)
            {
                Console.Write(EvenList.Value + " ");

                oddList = EvenList.Next;
                if (oddList != null)
                {
                    EvenList = oddList.Next;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
