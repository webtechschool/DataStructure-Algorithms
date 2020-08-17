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
            Node root = new Node(1);
            root.leftChild = new Node(2);
            root.rightChild = new Node(3);
            root.leftChild.leftChild = new Node(4);
            root.leftChild.rightChild = new Node(5);
            root.rightChild.leftChild = new Node(6);
            root.rightChild.rightChild = new Node(7);

            root = TreeOperation.InvertBinaryTree(root);
            TreeTraversal.LevelOrderTraversal(root);
       }
    }
}
