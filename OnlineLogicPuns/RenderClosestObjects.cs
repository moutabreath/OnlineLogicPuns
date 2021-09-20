using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    class RenderClosestObjects
    {
        public int solution(int[] D, int[] C, int P)
        {
            Sort(ref D, ref C);
            return SolutionAfterSort(D, C, P, 0);
        }

        private void Sort(ref int[] d, ref int[] c)
        {
            for (int i = 0; i < d.Count(); i++)
            {
                for (int  j = 0; j < d.Count(); j++)
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

        public int SolutionAfterSort(int[] D, int[] C, int P, int i)
        {
            if (P <= 0 || i >= C.Length)
            {
                return 0;
            }
            return Math.Max(1 + SolutionAfterSort(D, C, P - C[i], ++i),
                SolutionAfterSort(D,C, P, ++i));


    }

        private void printArray(int[] b)
        {
            for (int i = 0; i < b.Length; i++)
            {
                Console.Write($"{b[i]},");
            }
            Console.WriteLine();
        }

        //private static void Main(string[] args)
        //{
        //    RenderClosestObjects solution = new RenderClosestObjects();
        //    int[] A = { 5,11,1,3 };
        //    int[] B = { 6,1,3,2 };
        //    solution.solution(A, B, 7);

        //}
    }
}
