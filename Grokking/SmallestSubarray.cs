using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grokking
{
    internal class SmallestSubarray
    {
        public static int FindSmallestSubArray(int[] array, int S)
        {
            int smallestSum = 9999, windowStart = 0, intermediateSum = 0;

            for(int windowEnd = 0; windowEnd < array.Length;windowEnd++)
            {
                intermediateSum += array[windowEnd];

                while(intermediateSum >= S)
                {
                    Console.WriteLine("Length of subArray");
                    Console.WriteLine(windowEnd - windowStart + 1);
                    Console.WriteLine("Smallest length at the moment");
                    Console.WriteLine(smallestSum);
                    Console.WriteLine();
                    smallestSum = (windowEnd - windowStart + 1 < smallestSum) ? windowEnd - windowStart + 1 : smallestSum;
                    intermediateSum -= array[windowStart];
                    windowStart++;
                }
            }
            
            return smallestSum;
        }
    }
}
