using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grokking
{
    internal class MaxSum
    {
        public static int FindMaximum(int[] nums, int k)
        {
            int windowStart = 0;
            int max = 0;
            int sum = 0;

            for (int windowEnd = 0;windowEnd<nums.Length;windowEnd++)
            {
                sum += nums[windowEnd];
                if(windowEnd >= k-1)
                {
                    max = (sum > max)?sum:max;
                    sum -= nums[windowStart];
                    windowStart++;
                }
            }

            return max;
        }
    }
}
