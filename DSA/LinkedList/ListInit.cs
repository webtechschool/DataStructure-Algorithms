using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.LinkedList
{
    class ListInit
    {
        public ListInit()
        {
            ListNode head = null;
            Console.WriteLine("The Linked List is before:");
            ListOperation.DisplayList(head);

            ListNode nodeTobeDeleted = head.Next;
            ListOperation.DeleteWithOutHeadPointer(nodeTobeDeleted);
            Console.WriteLine("The Linked List is After Deletion:");
            ListOperation.DisplayList(head);
            ListNode reverseList = ListOperation.ReverseList(head);
            Console.WriteLine("The Linked List is After Reversal:");
            ListOperation.DisplayList(reverseList);


            head = ListOperation.InsertAtBeginning(head, 2);
            Console.WriteLine("The Linked List is after insertion at beginning:");
            ListOperation.DisplayList(head);

            head = ListOperation.InsertAtEnd(head, 10);
            Console.WriteLine("The Linked List is after insertion at end:");
            ListOperation.DisplayList(head);

            ListNode l1 = new ListNode(1);
            l1.Next = new ListNode(2);
            l1.Next.Next = new ListNode(5);
            l1.Next.Next.Next = new ListNode(6);

            ListNode l2 = new ListNode(1);
            l2.Next = new ListNode(3);
            l2.Next.Next = new ListNode(4);
            l2.Next.Next.Next = new ListNode(9);

            var r = ListOperation.MergeTwoSortedList(l1, l2);
            Console.WriteLine("The Linked List is after Merge");
            ListOperation.DisplayList(r);
        }
    }
}
