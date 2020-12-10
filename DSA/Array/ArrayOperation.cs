using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Array
{
    public class ArrayOperation
    {
        public static bool CheckSubArraySum(int [] a, int k)
        {
            List<int> queue = new List<int>();
            int sum = 0;

            for(int i =0; i< a.Length; i++)
            {
                queue.Add(a[i]);
                sum = sum + a[i];

                if(sum > k)
                {
                    var ele = queue.ElementAt(0);
                    queue.RemoveAt(0);
                    sum = sum - ele;
                }

                if(sum == k)
                {
                    if(queue.Count >= 2)
                    return true;
                }
            }

            while(sum > k)
            {
                var ele = queue.ElementAt(0);
                queue.RemoveAt(0);
                sum = sum - ele;
                if (sum == k)
                {
                    if (queue.Count >= 2)
                        return true;
                }
            }

            return false;
        }
    }
}
