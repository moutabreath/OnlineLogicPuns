//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;

//namespace AmazonLogicPuns
//{

//    class Result
//    {

//        /*
//         * Complete the 'getNumberOfOptions' function below.
//         *
//         * The function is expected to return a LONG_INTEGER.
//         * The function accepts following parameters:
//         *  1. INTEGER_ARRAY priceOfJeans
//         *  2. INTEGER_ARRAY priceOfShoes
//         *  3. INTEGER_ARRAY priceOfSkirts
//         *  4. INTEGER_ARRAY priceOfTops
//         *  5. INTEGER dollars
//         */

//        public static long getNumberOfOptions(List<int> priceOfJeans, List<int> priceOfShoes, List<int> priceOfSkirts, List<int> priceOfTops, int dollars)
//        {
//            if (dollars < 0)
//            {
//                return int.MinValue;
//            }
//            if (dollars == 0 || priceOfJeans.Count == 0 && priceOfShoes.Count == 0 && priceOfSkirts.Count == 0 && priceOfTops.Count == 0)
//            {
//                return 0;
//            }
//            return Math.Max
//          (
//              1 + Math.Max(
//                  getNumberOfOptions(TrimList(priceOfJeans), priceOfShoes, priceOfSkirts, priceOfTops, dollars - priceOfJeans.LastOrDefault()),
//                  getNumberOfOptions(priceOfJeans, TrimList(priceOfJeans), priceOfSkirts, priceOfTops, dollars - priceOfShoes.LastOrDefault())

//              )
//          ,
//              1 + Math.Max(
//                  getNumberOfOptions(priceOfJeans, priceOfShoes, TrimList(priceOfSkirts).ToList(), priceOfTops, dollars - priceOfSkirts.LastOrDefault()),
//                  getNumberOfOptions(priceOfJeans, priceOfShoes, priceOfSkirts, TrimList(priceOfTops).ToList(), dollars - priceOfTops.LastOrDefault())
//              )
//          );



//        }

//        private static List<int> TrimList(List<int> listToTrim)
//        {
//            if (listToTrim.Count >= 1)
//            {
//                return listToTrim.Take(listToTrim.Count - 1).ToList();
//            }
//            return listToTrim;
//        }
//    }




//    class Solution
//    {
//        public static void Main(string[] args)
//        {
//            TextWriter textWriter = new StreamWriter("test.txt", true);// @System.Environment.GetEnvironmentVariable("AMAZON_TEST_PATH"), true);

//            int priceOfJeansCount = Convert.ToInt32(Console.ReadLine().Trim());

//            List<int> priceOfJeans = new List<int>();

//            for (int i = 0; i < priceOfJeansCount; i++)
//            {
//                int priceOfJeansItem = Convert.ToInt32(Console.ReadLine().Trim());
//                priceOfJeans.Add(priceOfJeansItem);
//            }

//            int priceOfShoesCount = Convert.ToInt32(Console.ReadLine().Trim());

//            List<int> priceOfShoes = new List<int>();

//            for (int i = 0; i < priceOfShoesCount; i++)
//            {
//                int priceOfShoesItem = Convert.ToInt32(Console.ReadLine().Trim());
//                priceOfShoes.Add(priceOfShoesItem);
//            }

//            int priceOfSkirtsCount = Convert.ToInt32(Console.ReadLine().Trim());

//            List<int> priceOfSkirts = new List<int>();

//            for (int i = 0; i < priceOfSkirtsCount; i++)
//            {
//                int priceOfSkirtsItem = Convert.ToInt32(Console.ReadLine().Trim());
//                priceOfSkirts.Add(priceOfSkirtsItem);
//            }

//            int priceOfTopsCount = Convert.ToInt32(Console.ReadLine().Trim());

//            List<int> priceOfTops = new List<int>();

//            for (int i = 0; i < priceOfTopsCount; i++)
//            {
//                int priceOfTopsItem = Convert.ToInt32(Console.ReadLine().Trim());
//                priceOfTops.Add(priceOfTopsItem);
//            }

//            int dollars = Convert.ToInt32(Console.ReadLine().Trim());

//            long result = Result.getNumberOfOptions(priceOfJeans, priceOfShoes, priceOfSkirts, priceOfTops, dollars);

//            textWriter.WriteLine(result);

//            textWriter.Flush();
//            textWriter.Close();
//        }
//    }
//}
