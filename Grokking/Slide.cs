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
            double[] result = new double[arr.Length - k+1];
            double intermediateResult = 0;
            int windowStart = 0;
            for (int windowEnd = 0; windowEnd < arr.Length; windowEnd++)
            {
                intermediateResult += arr[windowEnd];
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
