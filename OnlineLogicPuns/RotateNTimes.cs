using System;

namespace Codility
{
    class RotateNTimes
    {
        public int[] solution(int[] A, int K)
        {
            if (A == null || A.Length == 0 || A.Length == 1) return A;

            int[] B = null;
            for(int i = 1; i <= K; i++)
            {
                B = Rotate(A);
                Console.Write($"i:{i}, ");
                printArray(B);
            }
            return B;
        }

        private void printArray(int[] b)
        {
            for(int i = 0; i < b.Length; i++)
            {
                Console.Write($"{b[i]},");
            }
            Console.WriteLine();
        }

        private int[] Rotate(int[] a)
        {
           for (int i = 0; i < a.Length - 1; i++)
            {
                Replace(a, a.Length - i - 1, a.Length - i - 2);
            }

            return a;
        }

        private void Replace(int[] a, int sourceIndex, int destIndex)
        {
            int temp = a[destIndex];            
            a[destIndex] = a[sourceIndex];
            a[sourceIndex] = temp;
        }

        //private static void Main(string[] args)
        //{
        //    RotateNTimes solution = new RotateNTimes();
        //    int[] A = { 1, 2, 3, 4, 5, 6, 7, 8,9,10,11,12,13,14,15 };
        //    Random rand = new Random();
        //    for (int i = 0; i < A.Length; i++)
        //    {
        //        A[i] = rand.Next(0,50);
        //    }
        //    solution.printArray(A);
        //    Console.WriteLine();
        //    A = solution.solution(A, 15);
        //}
    }
}
