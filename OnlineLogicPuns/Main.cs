using System;
using System.Collections.Generic;
using System.IO;

namespace OnlineLogicPuns
{
    public class EntryPoint
    {
        private static void TestPromotionsFromConsole()
        {
            TextWriter textWriter = new StreamWriter("test.txt", true);// @System.Environment.GetEnvironmentVariable("AMAZON_TEST_PATH"), true);
            int priceOfJeansCount = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> priceOfJeans = new List<int>();
            for (int i =  0; i < priceOfJeansCount; i++)
            {
                int priceOfJeansItem = Convert.ToInt32(Console.ReadLine().Trim());
                priceOfJeans.Add(priceOfJeansItem);
            }

            int priceOfShoesCount = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> priceOfShoes = new List<int>();
            for (int i = 0; i < priceOfShoesCount; i++)
            {
                int priceOfShoesItem = Convert.ToInt32(Console.ReadLine().Trim());
                priceOfShoes.Add(priceOfShoesItem);
            }

            int priceOfSkirtsCount = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> priceOfSkirts = new List<int>();
            for (int i = 0; i<priceOfSkirtsCount; i++)
            {
                int priceOfSkirtsItem = Convert.ToInt32(Console.ReadLine().Trim());
                priceOfSkirts.Add(priceOfSkirtsItem);
            }

            int priceOfTopsCount = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> priceOfTops = new List<int>();
            for (int i = 0; i<priceOfTopsCount; i++)
            {
                int priceOfTopsItem = Convert.ToInt32(Console.ReadLine().Trim());
                priceOfTops.Add(priceOfTopsItem);
            }

            int dollars = Convert.ToInt32(Console.ReadLine().Trim());
            long result = PromotionsResult.GetNumberOfOptions(priceOfJeans, priceOfShoes, priceOfSkirts, priceOfTops, dollars);
            textWriter.WriteLine(result);
            textWriter.Flush();
            textWriter.Close();
        }   
    }
}