using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.CompilerServices;

namespace Grokking
{
    internal class TripletCloseToTarget
    {
        public static int GetTripletSum()
        {
            List<int[]> triplets = new();
            List<int> items = new();
            int target = 2;
            int smallestSum = int.MaxValue;

            int[] arr = new int[] { 1, 0, 1, 1 };
            Array.Sort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                if (i > 0 && arr[i] == arr[i - 1])
                {
                    continue;
                }

                smallestSum = Search_Pair(arr, arr[i], i + 1, smallestSum, items, 100);
            }

            return 0;
        }

        private static int Search_Pair(int[] arr, int targetValue, int left, int smallestSum, List<int> items, int targetSum)
        {
            var right = arr.Length - 1;

            while (left < right)
            {
                var currentSum = arr[left] + arr[right] + targetValue;
                var targetDiff = targetSum - currentSum;

                if (targetDiff == 0)
                {
                    return currentSum;
                }

                if (Math.Abs(targetDiff) < Math.Abs(smallestSum) ||
                    Math.Abs(targetDiff) == Math.Abs(smallestSum) && targetDiff > smallestSum)
                {
                    smallestSum = targetDiff;
                }

                if (targetDiff > 0)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return targetSum - smallestSum;
        }
    }
}
