using System;
using System.Linq;
using System.Text;

namespace Codility
{
    /// <summary>
    /// Given an int N, return largest number if you delete exactly one '5' from the number N
    /// </summary>
    public class DeleteFiveFromInt
    {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        public int solution(int N)
        {
            string number = N.ToString();
            int maxFiveIndex = 0;
            for(int i  =0; i < number.Length; i++)
            {
                if (number[i] == '5' && i > maxFiveIndex)
                {
                    maxFiveIndex = i;
                }
            }
            return solution(N.ToString(), false, 0, new StringBuilder(), maxFiveIndex);
        }

        public int solution (string N, bool isFiveDropped, int index, StringBuilder currentNumber, int maxFiveIndex)
        {
            if (currentNumber.Length == N.Count() -1 )
            {
                int temp;
                int.TryParse(currentNumber.ToString(), out temp);
                return temp;
            }
            char currentDigit = N[index];
            if (currentDigit != '5')
            {
                currentNumber.Append(currentDigit);
                return solution(N, isFiveDropped, ++index, currentNumber, maxFiveIndex);
            }
            else
            {
                if (isFiveDropped)
                {
                    return solution(N, true, ++index, currentNumber.Append(currentDigit), maxFiveIndex);
                }
                if (index == maxFiveIndex)
                {
                    index++;
                    while (currentNumber.Length < N.Count() - 1 )
                    {
                        currentNumber.Append(N[index]);
                    }
                    int temp;
                    int.TryParse(currentNumber.ToString(), out temp);
                    return temp;
                }
                index++;
                StringBuilder sb = new StringBuilder(currentNumber.ToString());
                return Math.Max(solution(N, false, index, currentNumber.Append(currentDigit), maxFiveIndex),
                    solution(N, true, index, sb, maxFiveIndex));
            }

        }
    }
}
