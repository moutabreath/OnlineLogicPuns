using System;

namespace OnlineLogicPuns
{
    class RotateNTimes
    {
        public int[] solution(int[] A, int K)
        {
            if (A == null || A.Length == 0 || A.Length == 1) return A;

            int[] B = null;
            for (int i = 1; i <= K; i++)
            {
                B = Rotate(A);
                printArray(B);
            }
            return B;
        }

        private void printArray(int[] b)
        {
            for (int i = 0; i < b.Length; i++)
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
    }
}
