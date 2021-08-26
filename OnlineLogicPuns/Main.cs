using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace OnlineLogicPuns
{
    public class EntryPoint
    {
        public static void Main(string[] args)
        {


        }

        private static void TestStockPrices()
        {           
            // TestAmazonPromotions();
            // TestMostCommonWord();
            //    TestKTopMost();
            // string result = Decipher("aHR0cHM6Ly9ybmQuZWJheS5jby5pbC9yaWRkbGUvbXpmYmFiZXdjZXlxeGFsdXIv");
            // Console.WriteLine(result);
            // Decipher(@"C:\Users\tdruc\Downloads\download.jpg");

            // List<string> perms = FindAllPermutations("abcd", 0);
            double[] array = new double[20];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
            array[18] = 21;
            StockPrices.FindMaxStockPrices(array);
            _ = Console.ReadLine();
        }

        private static void TestPromotionsFromConsole()
        {
            TextWriter textWriter = new StreamWriter("test.txt", true);// @System.Environment.GetEnvironmentVariable("AMAZON_TEST_PATH"), true);

            int priceOfJeansCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> priceOfJeans = new List<int>();

            for (int i = 0; i<priceOfJeansCount; i++)
            {
                int priceOfJeansItem = Convert.ToInt32(Console.ReadLine().Trim());
                priceOfJeans.Add(priceOfJeansItem);
            }

            int priceOfShoesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> priceOfShoes = new List<int>();

            for (int i = 0; i<priceOfShoesCount; i++)
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

        private static void TestMostCommonWord()
        {
            string paragraph = "Bob hit a ball, the hit BALL flew far after it was hit.";
            string[] banned = {"hit"};
            MostCommonWordSolver mostCommonWord = new MostCommonWordSolver();
            string most = mostCommonWord.FindMostCommonWord(paragraph, banned);
        }


        private static List<string> FindAllPermutations(string st, int index)
        {
            List<string> perms = new List<string>();

            if (st.Length == index)
            {
                return perms;
            }
            perms.Add(st);
            for (int i = 0; i < st.Length; i++)
            {
                string st1 = SwapChars(st, i, index);
                
                perms.AddRange(FindAllPermutations(st1, ++index));
            }

            return perms;

        }

        private static string SwapChars(string st, int index1, int index2)
        {
            char temp = st.ElementAt(index1);
            char c = st.ElementAt(index2);
            StringBuilder sb = new StringBuilder();
            if (index2 == index1)
            {
                sb = new StringBuilder(st);
            }
            else
            {
                for (int j = 0; j < st.Length; j++)
                {
                    if (j == index2)
                    {
                        sb.Append(temp);
                        continue;
                    }

                    if (j == index1)
                    {
                        sb.Append(c);
                        continue;
                    }
                    sb.Append(st.ElementAt(j));
                }
            }
            return sb.ToString();
        }

        private static void TestPromotions()
        {
            List<List<string>> codeList1 = new List<List<string>>(){
            new List<string> { "apple", "apple" },
            new List<string> { "banana", "anything", "banana" } };

            string[] shoppingCart1 = { "orange", "apple", "apple", "banana", "orange", "banana" };
            string[] shoppingCart2 = { "banana", "orange", "banana", "apple", "apple", "anything" };
            string[] shoppingCart3 = { "apple", "banana", "apple", "orange", "banana" };
            string[] shoppingCart4 = { "apple", "apple", "apple", "banana" };
            SelectedItemsPromotions selecctedItemsPromotions = new SelectedItemsPromotions();
            selecctedItemsPromotions.DetermineIfCartIsPromoted(codeList1, shoppingCart1);
        }

        private static void TestKTopMost()
        {
            int k = 2;
            string[] keywords = { "anacell", "cetracular", "betacellular" };
            string[] reviews = {  "Anacell provides the best services in the city",
                        "betacellular has awesome services",
                        "Best services provided by anacell, everyone should use anacell"};
            TopKMostFrequent topKMostFrequent = new TopKMostFrequent();
            string[] result = topKMostFrequent.FindTopKMostWantedKeywords(k, keywords, reviews);

        }
    }
}