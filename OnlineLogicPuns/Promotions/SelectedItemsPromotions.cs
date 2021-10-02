using System;
using System.Collections.Generic;

namespace OnlineLogicPuns
{
    public class SelectedItemsPromotions
    {      
        public void DetermineIfCartIsPromoted(List<List<string>> codeList,  string[] shoppingCart)
        {
            string fruit = null;
            int totalFruitsNum = CountTotalFruits(codeList);
            int streak = 0;
            for (int i = 0; i < shoppingCart.Length; i++)
            {
                List<string> group = null;
                for (int j = 0; j < codeList.Count; j++)
                {
                    group = codeList[j];
                    for (int k = 0; k < group.Count - 1; k++)
                    {
                        if (i >= shoppingCart.Length)
                        {
                            Console.WriteLine("0");
                            return;
                        }
                        fruit = shoppingCart[i];
                        i++;
                        string codeListFruit = group[k];

                        if (fruit == codeListFruit || codeListFruit == "anything")
                        {
                            streak++;
                        }
                        else
                        {
                            if (k > 0)
                            {
                                streak = 0;
                            }
                            k--;

                        }
                    }
                    string lastCodeListFruit = group[codeList.Count - 1];
                    fruit = shoppingCart[i];
                    i++;
                    if (fruit == lastCodeListFruit || lastCodeListFruit == "anything")
                    {
                        streak++;
                    }
                }
            }

            if (streak == totalFruitsNum) Console.WriteLine("1");
            else
            {
                Console.WriteLine($"0 {streak}");
            }
            Console.ReadLine();
        }

        private int CountTotalFruits(List<List<string>> codeList)
        {
            int counter = 0;
            foreach (List<string> group in codeList)
            {
                counter += group.Count;
            }
            return counter;
        }
    }
}

