using System;
using System.Collections.Generic;
using System.Text;

namespace Algorigthms
{
    public class BestTimetoBuyandSellStockII
    {
        public int MaxProfit(int[] prices)
        {

            int maxprofit = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > prices[i - 1])
                    maxprofit += prices[i] - prices[i - 1];
            }
            return maxprofit;
        }

    }
}
