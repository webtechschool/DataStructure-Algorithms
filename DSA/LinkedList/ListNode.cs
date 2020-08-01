using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.LinkedList
{
    public class ListNode
    {
        public ListNode(int data)
        {
            this.Data = data;
        }
        public int Data { get; set; }
        public ListNode Next { get; set; }
    }
}
