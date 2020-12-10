using DSA.Array;
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
            int[] a1 = new int[] { 1, 2, 3, 7, 5 };

            int[] a2 = new int[] { 23, 2, 4, 2, 1 };

            var result = ArrayOperation.CheckSubArraySum(a1, 12);
            Console.WriteLine($"The Sum Value Exists In SubArray : {result}");

            result = ArrayOperation.CheckSubArraySum(a2, 6);
            Console.WriteLine($"The Sum Value Exists In SubArray : {result}");

            result = ArrayOperation.CheckSubArraySum(a1, 14);
            Console.WriteLine($"The Sum Value Exists In SubArray : {result}");

            Console.Read();
        }
    }
}
