using System;
using System.Collections.Generic;

namespace Grokking // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] result = MakeSquares(new int[] {-3, -1, 0, 1, 2});

            for(int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }

            TripletCloseToTarget.GetTripletSum();
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