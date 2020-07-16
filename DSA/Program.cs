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

            root.leftChild.leftChild = new Node(4);
            root.leftChild.rightChild = new Node(5);

            Console.WriteLine("In Order Traversal");
            TreeTraversal.InOrderTraversal(root);

            Console.WriteLine("In Order Traversal Iterative");
            TreeTraversal.InOrderTraversalIterative(root);

            Console.WriteLine("Pre Order Traversal");
            TreeTraversal.PreOrderTraversal(root);

            Console.WriteLine("Post Order Traversal");
            TreeTraversal.PostOrderTraversal(root);

            Console.Read();
        }
    }
}
