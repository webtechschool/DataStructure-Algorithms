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

        public static ListNode MergeTwoSortedList(ListNode l1, ListNode l2)
        {
            if (l1 == null)
                return l2;

            if (l2 == null)
                return l1;

            ListNode result = null;
            ListNode temp = null;
            while(l1 != null || l2 != null)
            {
                if(l1 == null)
                {
                   temp = PushToResult(temp, l2);
                    break;
                }

                if(l2 == null)
                {
                    temp = PushToResult(temp, l1);
                    break;
                }
                if(l1.Data <= l2.Data)
                {
                    temp = PushToResult(temp, l1);
                    l1 = l1.Next;
                }
                else if(l2.Data <= l1.Data)
                {
                    temp = PushToResult(temp, l2);
                    l2 = l2.Next;
                }

                if(result == null)
                {
                    result = temp;
                }
            }

            return result;
        }

        private static ListNode PushToResult(ListNode head, ListNode node)
        {
            if(head == null)
            {
                head = node;
                return head;
            }

            head.Next = node;
            head = node;
            return head;
        }

        public static bool IsLoopExist(ListNode head)
        {
            if (head == null)
                return false;

            ListNode fp = head;
            ListNode sp = head;

            while(sp != null && fp != null && fp.Next != null)
            {
                fp = fp.Next.Next;
                sp = sp.Next;
                if (sp == fp)
                    return true;
            }
            return false;            
        }
    }
}
