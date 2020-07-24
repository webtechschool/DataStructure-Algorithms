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
