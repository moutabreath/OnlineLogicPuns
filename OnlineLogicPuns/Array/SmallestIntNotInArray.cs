using System.Collections.Generic;

namespace OnlineLogicPuns
{
    public class SmallestIntNotInArray
    {
        public IDictionary<int, bool> _existingNumbers = new Dictionary<int, bool>();
        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            int max = 0;
            bool myBool = false;
            int min = A[0];
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                {
                    if (!_existingNumbers.TryGetValue(A[i], out myBool))
                    {
                        _existingNumbers.Add(A[i], true);
                    }
                    if (A[i] > max)
                    {
                        max = A[i];
                    }
                    if (A[i] < min)
                    {
                        min = A[i];
                    }
                }
            }


            int smallest = max + 1;
            int k = min;
            if (k <= 0)
            {
                k = 1;
            }
            while (_existingNumbers.TryGetValue(k, out myBool))
            {
                k++;
            }
            if (k < smallest)
            {
                return k;
            }
            return smallest;
        }

    }
}
