//This Program to combine two list in site.

using System;

namespace ZipTwoList
{
    class Node
    {
        public int val;
        public Node next;

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zip Two List!");
            var list1 = MakeList(1, 3, 5, 7, 7, 9);
            var list2 = MakeList(2, 6, 7, 8);
            PrintList(list1);
            PrintList(list2);

            Node zipper = ZipList(list1, list2);
            PrintList(zipper);
        }

        static Node MakeList(params int[] a)
        {
            Node head = null;
            //Node head = new Node();
            for (int i = a.Length - 1; i >= 0; i--)
            {
                head = new Node { val = a[i], next = head };

            }

            return head;
        }

        static void PrintList(Node list)
        {
            while (list != null)
            {
                Console.Write("{0} -> ", list.val);
                list = list.next;
            }
            Console.WriteLine();
        }

        static Node ZipList(Node p, Node q)
        {
            Node head = new Node();// Node head = null; it is not right. It didn't has next act.
            Node current = head;
            while (p!=null && q!=null)
            {
                if(p.val <= q.val)
                {
                    current.next = p;                    
                    p = p.next;
                }
                else
                {
                    current.next = q;                    
                    q = q.next;
                }
                current = current.next;                
            }

            /*
            if (p == null)
            {
                current.next = q;
            }
            else
            {
                current.next = p;
            }
            */
            //revise above to one line with Ternary operator
            current.next = p== null ? (q) : (p);


            return head.next;
        }
    }
}