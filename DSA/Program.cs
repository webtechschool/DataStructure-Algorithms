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

            Console.Read();
        }
    }
}
