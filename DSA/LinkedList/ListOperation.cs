using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.LinkedList
{
    public static class ListOperation
    {
        public static void DisplayList(ListNode head)
        {
            if (head == null)
                return;

            while(head != null)
            {
                Console.WriteLine(head.Data);
                head = head.Next;
            }
        }

        public static ListNode InsertAtBeginning(ListNode head, int data)
        {
            ListNode newNode = new ListNode(data);

            if(head == null)
            {
                head = newNode;
            }
            else
            {
                newNode.Next = head;
                head = newNode;
            }

            return head;

        }

        public static ListNode InsertAtEnd(ListNode head, int data)
        {
            ListNode newNode = new ListNode(data);
            ListNode root = head;
            if(head == null)
            {
                head = newNode;
            }
            else
            {
                while(head.Next != null)
                {
                    head = head.Next;
                }
                head.Next = newNode;                
            }
            return root;
        }

        public static ListNode InsertAfterNode(ListNode head, int nodeData, int newData)
        {
            ListNode newNode = new ListNode(newData);
            ListNode root = head;
            if(head == null)
            {
                head = newNode;
            }

            while(head != null)
            {
                if(head.Data == nodeData)
                {
                    break;
                }
                head = head.Next;
            }

            newNode.Next = head.Next;
            head.Next = newNode;

            return root
;
        }

        public static ListNode ReverseList(ListNode head)
        {
            if (head == null)
                return null;

            ListNode prev = null;
            ListNode curr = head;

            while(curr != null)
            {
                ListNode temp = curr.Next;
                curr.Next = prev;
                prev = curr;
                curr = temp;
            }

            return prev;
        }

        public static void DeleteWithOutHeadPointer(ListNode node)
        {
            if (node == null)
                return;

            if(node.Next == null)
            {
                return;
            }

            node.Data = node.Next.Data;
            node.Next = node.Next.Next;           
            
        }
    }
}
