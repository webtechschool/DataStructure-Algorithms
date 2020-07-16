using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    public class TreeTraversal
    {
        public static void InOrderTraversal(Node root)
        {
            if (root == null)
                return;
            InOrderTraversal(root.leftChild);
            Console.WriteLine(root.data);
            InOrderTraversal(root.rightChild);
        }

        public static void PreOrderTraversal(Node root)
        {
            if (root == null)
                return;

            Console.WriteLine(root.data);
            PreOrderTraversal(root.leftChild);
            PreOrderTraversal(root.rightChild);
        }

        public static void PostOrderTraversal(Node root)
        {
            if (root == null)
                return;
            PostOrderTraversal(root.leftChild);
            PostOrderTraversal(root.rightChild);
            Console.WriteLine(root.data);
        }

        public static void InOrderTraversalIterative(Node root)
        {
            if (root == null)
                return;

            Stack<Node> stack = new Stack<Node>();
            var node = root;

            while(node != null || stack.Count() > 0)
            {
                if(node != null)
                {
                    stack.Push(node);
                    node = node.leftChild;
                }
                else
                {
                    var ele = stack.Pop();
                    Console.WriteLine(ele.data);
                    node = ele.rightChild;
                }
            }
        }
    }
}
