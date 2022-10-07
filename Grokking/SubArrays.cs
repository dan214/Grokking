using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grokking
{
    internal class SubArraysWithProduct
    {
        public static List<int[]> SubArraysWith()
        {
            var arr = new int[] { 2, 5, 3, 10 };
            const int target = 30;

            var result = new List<int[]>();

            Array.Sort(arr);

            for (int i = 0; i < arr.Length - 1; i++)
            {
                var right = arr.Length - 1;
                var left = i + 1;

                if (arr[i] < target)
                {
                    result.Add(new int[] { arr[i] });
                }

                while (left < right)
                {
                    var currentProduct = arr[i] * arr[left];
                    if (currentProduct < target)
                    {
                        result.Add(new int[] { arr[i], arr[left] });
                        left++;
                    }
                }
            }

            return result;
        }
    }
}
