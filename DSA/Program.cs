using DSA.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    public class Node
    {
        public int data;

        public Node leftChild;
        public Node rightChild;

        public Node(int data)
        {
            this.data = data;
        }
    }
    class Program
    {        
        static void Main(string[] args)
        {
           
            Node root = new Node(1);
            root.leftChild = new Node(2);
            root.rightChild = new Node(3);

            root.rightChild.rightChild = new Node(6);

            root.leftChild.leftChild = new Node(4);
            root.leftChild.rightChild = new Node(5);

            root.leftChild.leftChild.leftChild = new Node(7);


            Console.WriteLine("In Order Traversal");
            TreeTraversal.InOrderTraversal(root);

            Console.WriteLine("In Order Traversal Iterative");
            TreeTraversal.InOrderTraversalIterative(root);

            Console.WriteLine("Pre Order Traversal");
            TreeTraversal.PreOrderTraversal(root);

            Console.WriteLine("Post Order Traversal");
            TreeTraversal.PostOrderTraversal(root);

            Console.WriteLine("Level Order Traversal");
            TreeTraversal.LevelOrderTraversal(root);

            Node BST = new Node(9);
            BST.leftChild = new Node(6);
            BST.rightChild = new Node(10);

            BST.leftChild.leftChild = new Node(4);
            BST.leftChild.rightChild = new Node(7);
            BST.rightChild.rightChild = new Node(11);

            var result = TreeOperation.IsBinarySearchTree(root);
            Console.WriteLine($"The Given Binary Tree Is Binary Search Tree : {result}");

            var height = TreeOperation.GetHeight(root, 0);
            Console.WriteLine($"The Height Of The Tree Is {height}");

            Node leftvIewTree = new Node(8);
            leftvIewTree.leftChild = new Node(5);
            leftvIewTree.rightChild = new Node(4);
            leftvIewTree.leftChild.leftChild = new Node(3);
            leftvIewTree.rightChild.leftChild = new Node(2);
            leftvIewTree.rightChild.rightChild = new Node(1);
            leftvIewTree.rightChild.rightChild.rightChild = new Node(9);

            Console.WriteLine("Left View Of Binary Tree");
            TreeOperation.LeftViewOfTree(leftvIewTree);

            Node RightViewTree = new Node(8);
            RightViewTree.leftChild = new Node(5);
            RightViewTree.rightChild = new Node(4);
            RightViewTree.leftChild.leftChild = new Node(3);
            RightViewTree.rightChild.leftChild = new Node(2);
            RightViewTree.rightChild.rightChild = new Node(1);
            RightViewTree.rightChild.rightChild.rightChild = new Node(9);

            Console.WriteLine("Right View Of Binary Tree: ");
            TreeOperation.RightViewOfTree(RightViewTree);


            ListNode head = new ListNode(8);
            head.Next = new ListNode(6);
            head.Next.Next = new ListNode(5);
            head.Next.Next.Next = new ListNode(7);

            

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

            Console.WriteLine("The Linked List is after insertion at after node 6:");
            head = ListOperation.InsertAfterNode(head, 6, 9);
            ListOperation.DisplayList(head);
            Console.Read();
        }
    }
}
