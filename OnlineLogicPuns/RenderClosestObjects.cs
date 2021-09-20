using System;
using System.Linq;

namespace OnlineLogicPuns
{
    public class RenderClosestObjects
    {
        /***
         * Simulate computer graphics where the closest objects are being rendered first.
         * Have D for distances
         * P for proecssing power
         * C for cost
         * Return the max number of objects that can be rendered given distances D, costs C and processing power P.
         * 
         * */
        public int solution(int[] D, int[] C, int P)
        {
            Sort(ref D, ref C);
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
