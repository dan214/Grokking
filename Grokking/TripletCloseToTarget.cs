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
            int target = 2;
            int smallestSum = Int32.MaxValue;

            int[] arr = new int[] { -2, 0, 1, 2 };
            Array.Sort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                if (i > 0 && arr[i] == arr[i - 1])
                {
                    continue;
                }

                smallestSum = Search_Pair(arr, arr[i], i + 1, triplets, smallestSum);
            }

            return 0;
        }

        private static int Search_Pair(int[] arr, int targetValue, int left, List<int[]> triplets, int smallestSum)
        {
            var right = arr.Length - 1;

            while (left < right)
            {
                var currentSum = arr[left] + arr[right] + targetValue;
                if (currentSum < smallestSum)
                {
                    smallestSum = currentSum;
                    left++;
                    right--;
                    while (left < right && arr[left] == arr[left - 1])
                    {
                        left++;
                    }
                    while (left < right && arr[right] == arr[right + 1])
                    {
                        right--;
                    }
                }
                else if (targetValue > currentSum)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }

            return smallestSum;
        }
    }
}
