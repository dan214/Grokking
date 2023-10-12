using System;
using System.Collections.Generic;

namespace Grokking // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TripletCloseToTarget.GetTripletSum();
            //TripletSumToZero.GetTripletSum();
            Console.WriteLine("Output");
            //Console.WriteLine(MaxSum.FindMaximum(new int[] { 2, 3, 4, 1, 5 },2));

            //Console.WriteLine(SmallestSubarray.FindSmallestSubArray(new int[] { 2, 1, 5, 2, 3, 2 }, 7));

            Console.WriteLine(LongestSubstring.FindLongestSubstring("cbbebi", 3));

            //var result = Slide.FindAverage(5, new int[] { 1, 3, 2, 6, -1, 4, 1, 8, 2 });

            //foreach (var t in result)
            //{
            //    Console.WriteLine(t);
            //}


        }

        private static int[] MakeSquares(int[] intArr)
        {
            int n = intArr.Length;
            int left = 0;
            int right = intArr.Length - 1;

            int inrer = intArr.Length - 1;

            int[] squareResults = new int[n];

            while(left < right)
            {
                int leftSquare = intArr[left] * intArr[left];
                int rightSquare = intArr[right] * intArr[right];

                if(leftSquare > rightSquare)
                {
                    squareResults[inrer] = leftSquare;
                    inrer--;
                    left++;
                }
                else
                {
                    squareResults[inrer] = rightSquare;
                    inrer--;
                    right--;
                }

            }
            return squareResults;

        }
    }
}