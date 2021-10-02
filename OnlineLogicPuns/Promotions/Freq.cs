using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace OnlineLogicPuns
{
    class Result
    {
        /*
         * Complete the 'taskOfPairing' function below.
         *
         * The function is expected to return a LONG_INTEGER.
         * The function accepts LONG_INTEGER_ARRAY freq as parameter.
         */

        public static long taskOfPairing(List<long> freq)
        {
            if (freq.Count == 0)
            {
                return 0;
            }

            long first = freq.Take(1).First();
            if (first == 0)
            {
                if(freq.Count == 0)
                {
                    return 0;
                }
                return taskOfPairing(freq.Skip(1).ToList());
            }
            if (first % 2 == 0)
            {
                return Math.Max(1 + taskOfPairing(DecreaseElementInList(freq, 0, 2)), taskOfPairing(DecreaseElementInList(freq, 1, 1)));
            }
            return 1 + taskOfPairing(DecreaseElementInList(freq, 1, 1));
        }

        public static List<long> DecreaseElementInList(List<long> listToDecrease, int index, int valueToTrim)
        {
            long first = listToDecrease.ElementAt(index);
            first -= valueToTrim;
            if (listToDecrease.Count == 1)
            {   
                return new List<long>() { first };
            }
            List<long> suffix = listToDecrease.Skip(index).ToList();
            List<long> prefix = listToDecrease.Take(index).ToList();
            
            if (index == 0)
            {
                List<long> freq2 = new List<long>() { first };
                freq2.AddRange(suffix);
                return freq2;
            }
            if (index == 1)
            {
                long secnodValue = suffix.First();
                secnodValue--;
                List<long> secondNode = new List<long>() { first };
                secondNode.Add(secnodValue);
                secondNode.AddRange(suffix.Skip(1));
                return secondNode;
            }
            return null;
        }

    }
    // class Solution
    // {
    //     public static void Main(string[] args)
    //     {
    //         List<long> longer = new List<long>()
    //         {
    //             3,5,4,3
    //         };

    //         long result = PromotionsResult.taskOfPairing(longer);
    //         ////TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
    //         //TextWriter textWriter = new StreamWriter("test.txt", true);

    //         //int freqCount = Convert.ToInt32(Console.ReadLine().Trim());

    //         //List<long> freq = new List<long>();

    //         //for (int i = 0; i < freqCount; i++)
    //         //{
    //         //    long freqItem = Convert.ToInt64(Console.ReadLine().Trim());
    //         //    freq.Add(freqItem);
    //         //}

    //         //long result = PromotionsResult.taskOfPairing(freq);

            //textWriter.WriteLine(result);

    //         //textWriter.Flush();
    //         //textWriter.Close();
    //     }
    // }
}
