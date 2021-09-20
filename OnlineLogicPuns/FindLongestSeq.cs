using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    class FindLongestSeq
    {
        public int solution(int N)
        {
            StringBuilder stringBuilder = new StringBuilder();
            while ( N > 0)
            {
                int remainder = N % 2;
                stringBuilder.Append(remainder);
                N = N / 2;
            }
            var binary = stringBuilder.ToString().Reverse();
            foreach(var st in binary)
            {
                Console.Write(st);
            }
            int currentSeq = 0;
            int maxSeq = 0;
            for (int i = 0;  i < binary.Count(); i++)
            {
                if (binary.ElementAt(i) == '0')
                {
                    currentSeq++;
                }
                else
                {
                    if (currentSeq > maxSeq)
                    {
                        maxSeq = currentSeq;
                    }
                    currentSeq = 0;
                }
            }

            return maxSeq;
         
        }    
    }
}
