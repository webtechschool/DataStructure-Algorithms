using DSA.Trees;
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

        public static void LevelOrderTraversal(Node root)
        {
            if (root == null)
                return;

            List<Node> list = new List<Node>();
            list.Add(root);
            while(list.Count() > 0)
            {
                int count = list.Count();
                while (count > 0)
                {
                    var ele = list.ElementAt(0);
                    list.RemoveAt(0);
                    Console.Write(ele.data + ",");
                    if (ele.leftChild != null)
                    {
                        list.Add(ele.leftChild);
                    }

                    if (ele.rightChild != null)
                    {
                        list.Add(ele.rightChild);
                    }

                    count--;
                }
                Console.WriteLine();
            }
        }

        public static void VerticalOrderTraversal(Node root)
        {
            if (root == null)
                return;
            SortedDictionary<int, List<Node>> map = new SortedDictionary<int, List<Node>>();

            List<nodeObj> queue = new List<nodeObj>();
            queue.Add(new nodeObj() { node = root, index = 0 });
            
            while (queue.Count() > 0)
            {
                var ele = queue.ElementAt(0);
                queue.RemoveAt(0);

                if(map.ContainsKey(ele.index))
                {
                    map[ele.index].Add(ele.node);
                }
                else
                {
                    map.Add(ele.index, new List<Node>() { ele.node });
                }
                
                if(ele.node.leftChild != null)
                {
                    queue.Add(new nodeObj() { node = ele.node.leftChild, index = ele.index - 1 });
                }

                if (ele.node.rightChild != null)
                {
                    queue.Add(new nodeObj() { node = ele.node.rightChild, index = ele.index + 1 });
                }
            }

            foreach(var keys in map.Keys)
            {
                var nodes = map[keys];
                foreach(var node in nodes)
                {
                    Console.Write(node.data + ",");
                }

                Console.WriteLine();
            }

        }

        public static void TopViewBinaryTree(Node root)
        {
            if (root == null)
                return;
            SortedDictionary<int, List<Node>> map = new SortedDictionary<int, List<Node>>();

            List<nodeObj> queue = new List<nodeObj>();
            queue.Add(new nodeObj() { node = root, index = 0 });

            while (queue.Count() > 0)
            {
                var ele = queue.ElementAt(0);
                queue.RemoveAt(0);

                if (map.ContainsKey(ele.index))
                {
                    map[ele.index].Add(ele.node);
                }
                else
                {
                    map.Add(ele.index, new List<Node>() { ele.node });
                }

                if (ele.node.leftChild != null)
                {
                    queue.Add(new nodeObj() { node = ele.node.leftChild, index = ele.index - 1 });
                }

                if (ele.node.rightChild != null)
                {
                    queue.Add(new nodeObj() { node = ele.node.rightChild, index = ele.index + 1 });
                }
            }

            foreach (var keys in map.Keys)
            {
                var nodes = map[keys];
                var data = nodes.ElementAt(0).data;
                Console.Write(data + ",");
            }
            Console.WriteLine();

        }

        public static void BottomViewBineryTree(Node root)
        {
            if (root == null)
                return;
            SortedDictionary<int, List<Node>> map = new SortedDictionary<int, List<Node>>();

            List<nodeObj> queue = new List<nodeObj>();
            queue.Add(new nodeObj() { node = root, index = 0 });

            while (queue.Count() > 0)
            {
                var ele = queue.ElementAt(0);
                queue.RemoveAt(0);

                if (map.ContainsKey(ele.index))
                {
                    map[ele.index].Add(ele.node);
                }
                else
                {
                    map.Add(ele.index, new List<Node>() { ele.node });
                }

                if (ele.node.leftChild != null)
                {
                    queue.Add(new nodeObj() { node = ele.node.leftChild, index = ele.index - 1 });
                }

                if (ele.node.rightChild != null)
                {
                    queue.Add(new nodeObj() { node = ele.node.rightChild, index = ele.index + 1 });
                }
            }

            foreach (var keys in map.Keys)
            {
                var nodes = map[keys];
                var data = nodes.ElementAt(nodes.Count - 1).data;
                Console.Write(data + ",");               
            }

            Console.WriteLine();

        }


    }

    public class nodeObj
    {
        public Node node;
        public int index;
    }
}
