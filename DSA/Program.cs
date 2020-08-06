using DSA.LinkedList;
using DSA.Trees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode head = new ListNode(1);
            head.Next = new ListNode(2);
            head.Next.Next = new ListNode(3);
            head.Next.Next.Next = new ListNode(4);
            head.Next.Next.Next.Next = new ListNode(5);
            head.Next.Next.Next.Next.Next = new ListNode(6);
            head.Next.Next.Next.Next.Next.Next = head.Next.Next;

            var result = ListOperation.IsLoopExist(head);
            Console.WriteLine("Loop Exist : " + result);
        }
    }
}
