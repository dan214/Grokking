using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grokking
{
    internal class TripletSumToZero
    {
        public static int GetTripletSum()
        {
            List<int[]> triplets = new();

            int[] arr = new int[] { -3, 0, 1, 2, -1, 1, -2 };
            Array.Sort(arr);

            for (int i = 0; i< arr.Length; i++)
            {
                if (i > 0 && arr[i] == arr[i - 1])
                {
                    continue;
                }

                Search_Pair(arr, -arr[i], i + 1, triplets);
            }

            return 0;
        }

        private static List<int[]> Search_Pair(int[] arr, int targetSum, int left, List<int[]> triplets)
        {
            var right = arr.Length - 1;

            while (left < right)
            {
                var currentSum = arr[left] + arr[right];
                if (currentSum == targetSum)
                {
                    triplets.Add(new int[] {-targetSum, arr[left], arr[right] });
                    left ++;
                    right --;
                    while (left < right && arr[left] == arr[left - 1])
                    {
                        left++;
                    }
                    while (left < right && arr[right] == arr[right + 1])
                    {
                        right--;
                    }
                }
                else if (targetSum > currentSum)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
            List<int[]> result = new List<int[]>();
            return result;
        }
    }
}
