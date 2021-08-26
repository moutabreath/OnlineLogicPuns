using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineLogicPuns
{
    public class EntryPoint
    {
        public static void Main(string[] args)
        {
            // TestAmazonPromotions();
            // TestMostCommonWord();
            //    TestKTopMost();
            // string result = Decipher("aHR0cHM6Ly9ybmQuZWJheS5jby5pbC9yaWRkbGUvbXpmYmFiZXdjZXlxeGFsdXIv");
            // Console.WriteLine(result);
            // Decipher(@"C:\Users\tdruc\Downloads\download.jpg");
            
            // List<string> perms = FindAllPermutations("abcd", 0);
            double[] array = new double[20];
            for(int i = 0; i < array.Length; i++){
                array[i] = i;
            }
            array[18] = 21;
            StockPrices.FindMaxStockPrices(array);
            _ = Console.ReadLine();

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