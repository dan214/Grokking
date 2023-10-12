using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grokking
{
    internal class LongestSubstring
    {
        public static int FindLongestSubstring(string text, int K)
        {
            int length = 0, windowStart = 0, uniqueCount = 0;
            List<char> chars = new List<char>();
            
            for(int windowEnd =  0; windowEnd < text.Length;windowEnd++)
            {
                if (!chars.Contains(text[windowEnd]))
                {
                    uniqueCount++;
                }
                chars.Add(text[windowEnd]);

                while (uniqueCount > K)
                {
                    chars.Remove(text[windowStart]);
                    
                    if(!chars.Contains(text[windowStart]))
                    {
                        uniqueCount--;
                    }
                    windowStart++;
                };
                

                if (uniqueCount <= K)
                {
                    length = (windowEnd - windowStart + 1 > length) ? windowEnd - windowStart + 1 : length;

                }
            }
            return length;
        }
    }
}
