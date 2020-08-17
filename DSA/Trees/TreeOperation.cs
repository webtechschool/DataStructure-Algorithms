using DSA.Trees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA
{
    public static class TreeOperation
    {
        public static bool IsBinarySearchTree(Node root)
        {
            if (root == null)
                return false;

            List<obj> queue = new List<obj>();
            queue.Add(new obj(root, Int32.MinValue, Int32.MaxValue));
            bool IsBst = true;
            while(queue.Count() > 0)
            {
                var ele = queue.ElementAt(0);
                queue.RemoveAt(0);

                if(ele.Node.data < ele.minValue || ele.Node.data > ele.maxValue)
                {
                    IsBst = false;
                    break;
                }

                if(ele.Node.leftChild != null)
                {
                    queue.Add(new obj(ele.Node.leftChild, ele.minValue, ele.Node.data));
                }

                if(ele.Node.rightChild != null)
                {
                    queue.Add(new obj(ele.Node.rightChild, ele.Node.data, ele.maxValue));
                }

            }

            return IsBst;
        }

        public static int GetHeight(Node root, int height)
        {
            if (root == null)
                return height;

            int leftHeight = GetHeight(root.leftChild, height + 1);
            int rightHeight = GetHeight(root.rightChild, height + 1);

            return leftHeight > rightHeight ? leftHeight : rightHeight;
        }

        public static void LeftViewOfTree(Node root)
        {
            if (root == null)
                return;

            List<Node> queue = new List<Node>();
            queue.Add(root);

            while(queue.Count() > 0)
            {
                int count = queue.Count();
                int counter = 0;
                while(count > 0)
                {
                    var ele = queue.ElementAt(0);
                    if(counter == 0)
                    {
                        Console.WriteLine(ele.data);
                    }
                    counter++;
                    queue.RemoveAt(0);

                    if (ele.leftChild != null)
                    {
                        queue.Add(ele.leftChild);
                    }
                    if (ele.rightChild != null)
                    {
                        queue.Add(ele.rightChild);
                    }


                    count--;
                }
            }
        }

        public static void RightViewOfTree(Node root)
        {
            if (root == null)
                return;

            List<Node> queue = new List<Node>();
            queue.Add(root);
            while(queue.Count() > 0)
            {
                int count = queue.Count;
                while(count > 0)
                {
                    var ele = queue.ElementAt(0);
                    queue.RemoveAt(0);

                    if(ele.leftChild != null)
                    {
                        queue.Add(ele.leftChild);
                    }

                    if(ele.rightChild != null)
                    {
                        queue.Add(ele.rightChild);
                    }
                    count--;
                }
            }

            
        }

        public static Node InvertBinaryTree(Node root)
        {
            if (root == null)
                return root;

            Node temp = root.leftChild;
            root.leftChild = root.rightChild;
            root.rightChild = temp;
            InvertBinaryTree(root.leftChild);
            InvertBinaryTree(root.rightChild);
            return root;
        }

        public class obj
        {
            public Node Node;
            public int minValue;
            public int maxValue;

            public obj(Node node, int minValue, int maxValue)
            {
                this.Node = node;
                this.minValue = minValue;
                this.maxValue = maxValue;
            }
            
        }
    }
}
