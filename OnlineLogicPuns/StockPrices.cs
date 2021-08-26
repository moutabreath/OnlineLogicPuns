    public class StockPrices
        {
            public static void FindMaxStockPrices(double[] prices)
            {
                double maxProfit = 0;
                int i = 0;
                int j = 0;
                for (i = 0; i < prices.Length; i++)
                {
                    for (j = i; j < prices.Length; j++)
                    {
                        if (prices[j] - prices[i] > maxProfit)
                        {
                            maxProfit = prices[j] - prices[i];
                        }
                        int j2 = j * 2;
                        if (j2 < prices.Length)
                        {
                            if (prices[j2] - prices[i] > maxProfit)
                            {
                                maxProfit = prices[j2] - prices[i];
                            }
                        }

                    }
                }
            }
        }