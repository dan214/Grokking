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

            var arr = new int[] { -1,1,2,3,4 };
            const int target = 5;
            Array.Sort(arr);

            for (int i = 0; i< arr.Length - 2; i++)
            {
                var right = arr.Length - 1;
                var left = i + 1;


                while (left < right)
                {

                    var currentSum = arr[left] + arr[right] + arr[i];

                    if (currentSum < target)
                    {
                        triplets.Add(new[] { arr[i], arr[left], arr[right]});
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }

            return 0;
        }
    }
}
