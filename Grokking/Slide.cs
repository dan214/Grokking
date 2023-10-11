using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grokking
{
    public class Slide
    {
        public static double[] FindAverage(int k, int[] arr)
        {
            double[] result = new double[k];
            double intermediateResult = 0;
            int windowStart = 0;
            int windowEnd = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                intermediateResult += arr[i];
                if (windowEnd == k-1)
                {
                    result[windowStart] = intermediateResult/k;
                    intermediateResult -= arr[windowStart];
                    windowStart++;
                }
                else
                {
                    windowEnd++;
                }
                
            }

            return result;
        }
    }
}
