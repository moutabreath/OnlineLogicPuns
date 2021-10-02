using System.Collections.Generic;

namespace OnlineLogicPuns
{
    /**
     * Find the smallest int not in the array
     */
    public class MinInteger
    {
        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int max = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > max)
                {
                    max = A[i];
                }
            }
            int min = max + 1;
            Dictionary<int, bool> dict = new Dictionary<int, bool>(max);
            for (int i = 0; i < A.Length; i++)
            {
                if (!dict.ContainsKey(A[i]))
                {
                    dict.Add(A[i], true);
                }
            }

            for (int i = 0; i < max; i++)
            {
                int tempMin = 0;
                if (dict.ContainsKey(A[i]))
                {
                    tempMin = A[i] + 1;
                    if (tempMin < min && !dict.ContainsKey(tempMin))
                    {
                        min = tempMin;
                    }
                }
            }
            return min;
        }
    }
}
