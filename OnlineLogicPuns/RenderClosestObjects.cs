using System;
using System.Linq;

namespace OnlineLogicPuns
{
    public class RenderClosestObjects
    {
        /***
         * Simulate computer graphics where the closest objects are being rendered first.
         * Have D for distances
         * P for preecssing power
         * C for cost
         * Return the max number of objects that can be rendered given distances D, costs C and processing power P.
         * 
         * */
        public int solution(int[] D, int[] C, int P)
        {
            QuickSortIterative(ref D,  ref C);
            return SolutionAfterSort(D, C, P, 0);
        }

        private void Sort(ref int[] d, ref int[] c)
        {
            for (int i = 0; i < d.Count(); i++)
            {
                for (int j = 0; j < d.Count(); j++)
                {
                    if (d[j] < d[i])
                    {
                        int temp = d[i];
                        d[i] = d[j];
                        d[j] = temp;
                        temp = c[i];
                        c[i] = c[j];
                        c[j] = temp;
                    }
                }
            }
        }

        public static void QuickSortIterative(ref int[] data, ref int [] other)
        {
            int startIndex = 0;
            int endIndex = data.Length - 1;
            int top = -1;
            int[] stack = new int[data.Length];

            stack[++top] = startIndex;
            stack[++top] = endIndex;

            while (top >= 0)
            {
                endIndex = stack[top--];
                startIndex = stack[top--];

                int p = Partition(ref data, startIndex, endIndex, ref other);

                if (p - 1 > startIndex)
                {
                    stack[++top] = startIndex;
                    stack[++top] = p - 1;
                }

                if (p + 1 < endIndex)
                {
                    stack[++top] = p + 1;
                    stack[++top] = endIndex;
                }
            }
        }

        private static int Partition(ref int[] data, int left, int right, ref int[] other)
        {
            int x = data[right];
            int i = (left - 1);

            for (int j = left; j <= right - 1; ++j)
            {
                if (data[j] <= x)
                {
                    ++i;
                    Swap(ref data[i], ref data[j], ref other[i], ref data[j]);
                }
            }

            Swap(ref data[i + 1], ref data[right], ref other[i+1], ref other[right]);

            return (i + 1);
        }

        private static void Swap(ref int a, ref int b, ref int a2, ref int b2)
        {
            int temp = a;
            a = b;
            b = temp;
            temp = a2;
            b2 = a2;
            b2 = a2;
        }

        private int SolutionAfterSort(int[] D, int[] C, int P, int i)
        {
            if (P <= 0 || i >= C.Length)
            {
                return 0;
            }
            return Math.Max(1 + SolutionAfterSort(D, C, P - C[i], ++i),
                SolutionAfterSort(D, C, P, ++i));
        }
    }
}
